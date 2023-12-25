using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace InzynierkaApi.Models;

public class StudentImagesModel
{
    [Key]
    public int ImageId { get; set; }

    // Assuming you want to store image data as a byte array
    public byte[] ImageData { get; set; }

    // Foreign key linking to StudentModel
    [ForeignKey("StudentModel")]
    public int StudentId { get; set; }
    public StudentModel Student { get; set; }
}