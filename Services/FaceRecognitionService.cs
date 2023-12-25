using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace InzynierkaApi.Services
{
    public class FaceRecognitionService
    {
        private const string TargetImageFolder = "C:\\Users\\igor3\\OneDrive\\Obrazy\\AttendanceCheckAppTestImages"; // Change this to the actual folder path
        private readonly float _similarityThreshold;
        private readonly AmazonRekognitionClient _rekognitionClient;

        public FaceRecognitionService(float similarityThreshold, string awsAccessKey, string awsSecretKey)
        {
            _similarityThreshold = similarityThreshold;
            _rekognitionClient = new AmazonRekognitionClient(awsAccessKey, awsSecretKey, Amazon.RegionEndpoint.EUCentral1);
        }

        public async Task<string> CompareFacesAsync(string sourceImagePath)
        {
            string matchedImage = null;
            bool matchFound = false;

            try
            {
                Console.WriteLine($"Reading source image from: {sourceImagePath}");

                byte[] sourceImageContent = await File.ReadAllBytesAsync(sourceImagePath);
                var imageSource = await LoadImageAsync(sourceImageContent);

                if (imageSource == null)
                {
                    Console.WriteLine("Failed to load the source image.");
                    return matchedImage;
                }

                Console.WriteLine("Source image loaded successfully.");

                var jpgFiles = Directory.GetFiles(TargetImageFolder, "*.jpg");

                foreach (var jpgFilePath in jpgFiles)
                {
                    try
                    {
                        Console.WriteLine($"Reading target image from: {jpgFilePath}");

                        byte[] targetImageContent = await File.ReadAllBytesAsync(jpgFilePath);
                        var imageTarget = await LoadImageAsync(targetImageContent);

                        if (imageTarget == null)
                        {
                            Console.WriteLine($"Failed to load target image: {jpgFilePath}");
                            continue;
                        }

                        var compareFacesRequest = new CompareFacesRequest
                        {
                            SourceImage = imageSource,
                            TargetImage = imageTarget,
                            SimilarityThreshold = _similarityThreshold,
                        };

                        var compareFacesResponse = await _rekognitionClient.CompareFacesAsync(compareFacesRequest);

                        // Verification of comparison results
                        if (compareFacesResponse.FaceMatches.Any(match => match.Similarity >= _similarityThreshold))
                        {
                            Console.WriteLine($"Match found with confidence above {_similarityThreshold}% in image: {jpgFilePath}");
                            matchedImage = Path.GetFileName(jpgFilePath);
                            matchFound = true;
                            // If a match is found, stop the loop
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"No match found in image: {jpgFilePath}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing target image {jpgFilePath}: {ex.Message}");
                        Console.WriteLine(ex.StackTrace);
                    }
                }

                // If a match is found, return immediately
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



        private async Task<Amazon.Rekognition.Model.Image> LoadImageAsync(byte[] imageContent)
        {
            try
            {
                return new Amazon.Rekognition.Model.Image { Bytes = new MemoryStream(imageContent) };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load image. Error: {ex.Message}");
                return null;
            }
        }
    }
}
