using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InzynierkaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewTestDataAndChangedCourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "StudentModel",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4386), "Inżynieria Oprogramowania" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 12, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4456), "Automatyka Przemysłowa" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 13, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4473), "Sensory i Układy Pomiarowe" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 14, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4488), "Technologie Mobilne" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4503), "Programowanie Robotów" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 16, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4521), "Komunikacja Człowiek-Komputer" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 17, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4536), "Sterowanie Procesami Dyskretnymi" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 18, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4551), "Robotyka Medyczna" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 19, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4566), "Systemy Wizyjne" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                columns: new[] { "DateOfClass", "NameOfClass" },
                values: new object[] { new DateTime(2024, 1, 20, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4583), "Automatyka i Robotyka w Medycynie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1000, "Automatyka i Robotyka", "Kierunek0", "Adam", "Nowak", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1001, "Automatyka i Robotyka", "Kierunek1", "Michał", "Kowalski", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1002, "Automatyka i Robotyka", "Kierunek2", "Andrzej", "Wiśniewski", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1003, "Automatyka i Robotyka", "Kierunek3", "Anna", "Wójcik", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1004, "Automatyka i Robotyka", "Kierunek4", "Katarzyna", "Kamińska", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1005, "Automatyka i Robotyka", "Kierunek5", "Mateusz", "Lewandowski", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1006, "Automatyka i Robotyka", "Kierunek6", "Magdalena", "Wójcik", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1007, "Automatyka i Robotyka", "Kierunek7", "Piotr", "Kowalczyk", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1008, "Automatyka i Robotyka", "Kierunek8", "Karolina", "Zielińska", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName", "StudentModel" },
                values: new object[] { 1009, "Automatyka i Robotyka", "Kierunek9", "Tomasz", "Jankowski", null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel0@example.com", "Jan", "Kowalski" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel1@example.com", "Anna", "Nowak" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel2@example.com", "Marek", "Wiśniewski" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel3@example.com", "Ewa", "Wójcik" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel4@example.com", "Krzysztof", "Lewandowska" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 6,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel5@example.com", "Barbara", "Zieliński" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 7,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel6@example.com", "Paweł", "Kamiński" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 8,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel7@example.com", "Joanna", "Wójcik" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 9,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel8@example.com", "Marcin", "Jankowski" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 10,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Automatyka i Robotyka", "nauczyciel9@example.com", "Agnieszka", "Kowalczyk" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentModel",
                table: "Students",
                column: "StudentModel");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_StudentModel",
                table: "Students",
                column: "StudentModel",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_StudentModel",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentModel",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentModel",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentsId",
                table: "Courses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 10, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2062), "Class1", "[1,2,3]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 11, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2138), "Class2", "[2,3,4]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 12, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2158), "Class3", "[3,4,5]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 13, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2176), "Class4", "[4,5,6]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 14, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2203), "Class5", "[5,6,7]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 15, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2221), "Class6", "[6,7,8]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 16, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2239), "Class7", "[7,8,9]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 17, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2256), "Class8", "[8,9,10]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 18, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2273), "Class9", "[9,10,11]" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                columns: new[] { "DateOfClass", "NameOfClass", "StudentsId" },
                values: new object[] { new DateTime(2024, 1, 19, 5, 57, 24, 27, DateTimeKind.Local).AddTicks(2300), "Class10", "[10,11,12]" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1001, "Department1", "Field1", "StudentFirstName1", "StudentLastName1" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1002, "Department2", "Field2", "StudentFirstName2", "StudentLastName2" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1003, "Department3", "Field3", "StudentFirstName3", "StudentLastName3" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1004, "Department4", "Field4", "StudentFirstName4", "StudentLastName4" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1005, "Department5", "Field5", "StudentFirstName5", "StudentLastName5" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1006, "Department6", "Field6", "StudentFirstName6", "StudentLastName6" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1007, "Department7", "Field7", "StudentFirstName7", "StudentLastName7" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1008, "Department8", "Field8", "StudentFirstName8", "StudentLastName8" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1009, "Department9", "Field9", "StudentFirstName9", "StudentLastName9" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                columns: new[] { "AlbumId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[] { 1010, "Department10", "Field10", "StudentFirstName10", "StudentLastName10" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department1", "teacher1@example.com", "TeacherFirstName1", "TeacherLastName1" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department2", "teacher2@example.com", "TeacherFirstName2", "TeacherLastName2" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department3", "teacher3@example.com", "TeacherFirstName3", "TeacherLastName3" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department4", "teacher4@example.com", "TeacherFirstName4", "TeacherLastName4" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department5", "teacher5@example.com", "TeacherFirstName5", "TeacherLastName5" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 6,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department6", "teacher6@example.com", "TeacherFirstName6", "TeacherLastName6" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 7,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department7", "teacher7@example.com", "TeacherFirstName7", "TeacherLastName7" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 8,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department8", "teacher8@example.com", "TeacherFirstName8", "TeacherLastName8" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 9,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department9", "teacher9@example.com", "TeacherFirstName9", "TeacherLastName9" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 10,
                columns: new[] { "Department", "Email", "FirstName", "LastName" },
                values: new object[] { "Department10", "teacher10@example.com", "TeacherFirstName10", "TeacherLastName10" });
        }
    }
}
