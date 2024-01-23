
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InzynierkaApi.Models
{
    public class CourseModel(string nameOfClass, int teacherId, DateTime dateOfClass)
    {
        [Key]
        public int CourseId { get; set; }
        public string NameOfClass { get; set; } = nameOfClass;
        public DateTime DateOfClass { get; set; } = dateOfClass;
        [ForeignKey("TeacherModel")] public int TeacherId { get; set; } = teacherId;
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

    }
}