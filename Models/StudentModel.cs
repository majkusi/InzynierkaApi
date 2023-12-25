using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InzynierkaApi.Models
{
    public class StudentModel(string firstName, string lastName, int albumId, string department, string fieldOfStudy)
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int AlbumId { get; set; } = albumId;
        public string? Department { get; set; } = department;
        public string? FieldOfStudy { get; set; } = fieldOfStudy;
        public List<int>? CourseId { get; set; }
        public List<StudentImagesModel>? StudentImages { get; set; }
    }
}
