using InzynierkaApi.Models;
using Microsoft.EntityFrameworkCore;


namespace InzynierkaApi.Context
{
    public class AttendanceContext : DbContext
    {
        public AttendanceContext(DbContextOptions<AttendanceContext> options) : base(options) { }

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<StudentImagesModel> StudentImages { get; set; }
        public DbSet<TeacherLoginModel> TeacherLogin { get; set; }

        public DbSet<AttendanceModel> AttendanceList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed 10 instances of StudentModel
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<StudentModel>().HasData(
                    new StudentModel($"StudentFirstName{i}", $"StudentLastName{i}", 1000 + i, $"Department{i}", $"Field{i}")
                    {
                        StudentId = i,
                        CourseId = new List<int> { i, i + 1, i + 2 } // Add any course IDs you want to associate with the student
                    }
                );

            }
            for (int i = 1; i <= 10; i++)
            {
                byte[] imageBytes = GetImageData($"C:\\Users\\igor3\\OneDrive\\Obrazy\\AttendanceCheckAppTestImages\\image{i}.jpg"); // Replace with the actual path to your image file

                modelBuilder.Entity<StudentImagesModel>().HasData(
                    new StudentImagesModel()
                    {
                        ImageId = i,
                        ImageData = imageBytes,
                        StudentId = i
                    }
                );
            }
            // Seed 10 instances of TeacherModel
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<TeacherModel>().HasData(
                    new TeacherModel($"TeacherFirstName{i}", $"TeacherLastName{i}", $"Department{i}", $"teacher{i}@example.com")
                    {
                        TeacherId = i,
                        //CourseId = new List<int> { i, i + 1, i + 2 } // Add any course IDs you want to associate with the teacher
                    }
                );
            }

            // Seed 10 instances of CourseModel
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<CourseModel>().HasData(
                new CourseModel($"Class{i}", i, DateTime.Now.AddDays(i))
                {
                CourseId = i,
                StudentsId = new List<int> { i, i + 1, i + 2 } // Add any student IDs you want to associate with the course
                }
                );
            }

            base.OnModelCreating(modelBuilder);
        }
        private byte[] GetImageData(string filePath)
        {
            // Read the image file and convert it to a byte array
            byte[] imageBytes;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imageBytes = br.ReadBytes((int)fs.Length);
                }
            }

            return imageBytes;
        }
    }
}



