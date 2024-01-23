using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InzynierkaApi.Models
{
    public class TeacherLoginModel
    {
        [Key]
        public int TeacherLoginId { get; set; }

        public string Password { get; set; }

        [ForeignKey("TeacherModel")]
        public string Email { get; set; }
    }
}