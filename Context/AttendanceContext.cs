using InzynierkaApi.Models;
using Microsoft.EntityFrameworkCore;
using System;


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
            string[] firstNames = { "Adam", "Michał", "Andrzej", "Anna", "Katarzyna", "Mateusz", "Magdalena", "Piotr", "Karolina", "Tomasz" };
            string[] lastNames = { "Nowak", "Kowalski", "Wiśniewski", "Wójcik", "Kamińska", "Lewandowski", "Wójcik", "Kowalczyk", "Zielińska", "Jankowski" };

            for (int i = 0; i < 10; i++)
            {
                modelBuilder.Entity<StudentModel>().HasData(
                    new StudentModel($"{firstNames[i]}", $"{lastNames[i]}", 1000 + i, $"Automatyka i Robotyka", $"Kierunek{i}")
                    {
                        StudentId = i + 1,
                        CourseId = new List<int> { i + 1, i + 2, i + 3 } // Dodaj dowolne identyfikatory kursów, z którymi chcesz powiązać studenta
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
            string[] teacherFirstNames = { "Jan", "Anna", "Marek", "Ewa", "Krzysztof", "Barbara", "Paweł", "Joanna", "Marcin", "Agnieszka" };
            string[] teacherLastNames = { "Kowalski", "Nowak", "Wiśniewski", "Wójcik", "Lewandowska", "Zieliński", "Kamiński", "Wójcik", "Jankowski", "Kowalczyk" };

            for (int i = 0; i < 10; i++)
            {
                modelBuilder.Entity<TeacherModel>().HasData(
                    new TeacherModel($"{teacherFirstNames[i]}", $"{teacherLastNames[i]}", $"Automatyka i Robotyka", $"nauczyciel{i}@example.com")
                    {
                        TeacherId = i + 1,
                        //CourseId = new List<int> { i + 1, i + 2, i + 3 } // Dodaj dowolne identyfikatory kursów, z którymi chcesz powiązać nauczyciela
                    }
                );
            }
            string[] courseNames = { "Inżynieria Oprogramowania", "Automatyka Przemysłowa", "Sensory i Układy Pomiarowe", "Technologie Mobilne", "Programowanie Robotów", "Komunikacja Człowiek-Komputer", "Sterowanie Procesami Dyskretnymi", "Robotyka Medyczna", "Systemy Wizyjne", "Automatyka i Robotyka w Medycynie" };
            // Seed 10 instances of CourseModel
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            { // Losowo wybierz trzech studentów spośród dostępnych 10 studentów
               
            
                modelBuilder.Entity<CourseModel>().HasData(
                    new CourseModel($"{courseNames[i]}", i + 1, DateTime.Now.AddDays(i))
                    {
                        CourseId = i + 1,
                    }
                );
            }

            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<TeacherLoginModel>().HasData(
                    new TeacherLoginModel
                    {
                        TeacherLoginId = i,
                        Password = "haslo123",
                        Email = $"teacher{i}@example.com" // Provide a valid email for the TeacherLoginModel
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



