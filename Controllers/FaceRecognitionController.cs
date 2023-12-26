using InzynierkaApi.Context;
using InzynierkaApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InzynierkaApi.Controllers
{
    [ApiController]
    [Route("api/")]
    [Consumes("multipart/form-data")]
    public class FaceRecognitionController : ControllerBase
    {
        private readonly FaceRecognitionService _faceRecognitionService;
        private readonly AttendanceContext _attendanceContext;

        public FaceRecognitionController(FaceRecognitionService faceRecognitionService, AttendanceContext attendanceContext)
        {
            _faceRecognitionService = faceRecognitionService;
            _attendanceContext = attendanceContext;
        }

        public class CompareFacesRequestModel
        {
            public IFormFile SourceImage { get; set; }
        }
        // In FaceRecognitionController
        [HttpPost("compare/{courseId}")]
        public async Task<IActionResult> CompareFaces([FromForm] CompareFacesRequestModel model,int courseId)
        {
            if (model == null || model.SourceImage == null)
            {
                return BadRequest("Invalid request model");
            }

            try
            {
                if (Path.GetExtension(model.SourceImage.FileName).ToLower() != ".jpg")
                {
                    return BadRequest("Only .jpg images are supported.");
                }

                byte[] sourceImageContent;
                using (var stream = new MemoryStream())
                {
                    await model.SourceImage.CopyToAsync(stream);
                    sourceImageContent = stream.ToArray();
                }

                var matchedImage = await _faceRecognitionService.CompareFacesAsync(sourceImageContent,courseId);

                if (!string.IsNullOrEmpty(matchedImage))
                {
                    return Ok($"Face comparison completed successfully. Matched image: {matchedImage}");
                }
                else
                {
                    return Ok("No matches found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
