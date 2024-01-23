using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using InzynierkaApi.Models;
using InzynierkaApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InzynierkaApi.Services
{
    public class FaceRecognitionService
    {
        private readonly float _similarityThreshold;
        private readonly AmazonRekognitionClient _rekognitionClient;
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IStudentRepository _studentRepository;
        public FaceRecognitionService(float similarityThreshold, string awsAccessKey, string awsSecretKey, IAttendanceRepository attendanceRepository, IStudentRepository studentRepository)
        {
            _similarityThreshold = similarityThreshold;
            _rekognitionClient = new AmazonRekognitionClient(awsAccessKey, awsSecretKey, Amazon.RegionEndpoint.EUCentral1);
            _attendanceRepository = attendanceRepository;
            _studentRepository = studentRepository;
        }
        public async Task<string> CompareFacesAsync(byte[] sourceImage, int courseId)
        {
            string matchedImage = String.Empty;
            bool matchFound = false;
            StudentModel? student = null;

            try
            {
                Console.WriteLine("Reading source image...");

                var imageSource = await LoadImageAsync(sourceImage);

                Console.WriteLine("Source image loaded successfully.");

                var allStudentImages = _studentRepository.GetStudentsWithImages();

                var tasks = allStudentImages.SelectMany(studentImage => studentImage.StudentImages.Select(image => Task.Run(async () =>
                {
                    Console.WriteLine($"Reading target image from StudentImagesModel with ImageId: {image.ImageId}");

                    var imageTarget = await LoadImageAsync(image.ImageData);

                    var compareFacesRequest = new CompareFacesRequest
                    {
                        SourceImage = imageSource,
                        TargetImage = imageTarget,
                        SimilarityThreshold = _similarityThreshold,
                    };

                    var compareFacesResponse = await _rekognitionClient.CompareFacesAsync(compareFacesRequest);

                    if (compareFacesResponse.FaceMatches.Any(match => match.Similarity >= _similarityThreshold))
                    {
                        Console.WriteLine($"Match found with confidence above {_similarityThreshold}% in image with ImageId: {image.ImageId}");
                        matchedImage = image.ImageId.ToString();
                        matchFound = true;
                        student = studentImage;
                        _attendanceRepository.PutNewAttendance(studentImage.StudentId, courseId, true);
                    }
                    else
                    {
                        Console.WriteLine($"No match found in image with ImageId: {image.ImageId}");
                    }
                })));

                await Task.WhenAll(tasks);

                if (matchFound)
                {
                    return matchedImage;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CompareFacesAsync: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }

            return matchedImage;
        }
        private async Task<Amazon.Rekognition.Model.Image?> LoadImageAsync(byte[] imageContent)
        {
            try
            {
                 return  new Amazon.Rekognition.Model.Image { Bytes = new MemoryStream(imageContent) };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load image. Error: {ex.Message}");
                return null;
            }
        }
    }
}
