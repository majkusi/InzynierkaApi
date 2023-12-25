using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InzynierkaApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameOfClass = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfClass = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FieldOfStudy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TeacherLogin",
                columns: table => new
                {
                    TeacherLoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLogin", x => x.TeacherLoginId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Department = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "DateOfClass", "NameOfClass", "StudentsId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 7, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7002), "Class1", "[1,2,3]", 1 },
                    { 2, new DateTime(2023, 12, 8, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7068), "Class2", "[2,3,4]", 2 },
                    { 3, new DateTime(2023, 12, 9, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7086), "Class3", "[3,4,5]", 3 },
                    { 4, new DateTime(2023, 12, 10, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7102), "Class4", "[4,5,6]", 4 },
                    { 5, new DateTime(2023, 12, 11, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7119), "Class5", "[5,6,7]", 5 },
                    { 6, new DateTime(2023, 12, 12, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7137), "Class6", "[6,7,8]", 6 },
                    { 7, new DateTime(2023, 12, 13, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7154), "Class7", "[7,8,9]", 7 },
                    { 8, new DateTime(2023, 12, 14, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7170), "Class8", "[8,9,10]", 8 },
                    { 9, new DateTime(2023, 12, 15, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7186), "Class9", "[9,10,11]", 9 },
                    { 10, new DateTime(2023, 12, 16, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7252), "Class10", "[10,11,12]", 10 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "AlbumId", "CourseId", "Department", "FieldOfStudy", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1001, "[1,2,3]", "Department1", "Field1", "StudentFirstName1", "StudentLastName1" },
                    { 2, 1002, "[2,3,4]", "Department2", "Field2", "StudentFirstName2", "StudentLastName2" },
                    { 3, 1003, "[3,4,5]", "Department3", "Field3", "StudentFirstName3", "StudentLastName3" },
                    { 4, 1004, "[4,5,6]", "Department4", "Field4", "StudentFirstName4", "StudentLastName4" },
                    { 5, 1005, "[5,6,7]", "Department5", "Field5", "StudentFirstName5", "StudentLastName5" },
                    { 6, 1006, "[6,7,8]", "Department6", "Field6", "StudentFirstName6", "StudentLastName6" },
                    { 7, 1007, "[7,8,9]", "Department7", "Field7", "StudentFirstName7", "StudentLastName7" },
                    { 8, 1008, "[8,9,10]", "Department8", "Field8", "StudentFirstName8", "StudentLastName8" },
                    { 9, 1009, "[9,10,11]", "Department9", "Field9", "StudentFirstName9", "StudentLastName9" },
                    { 10, 1010, "[10,11,12]", "Department10", "Field10", "StudentFirstName10", "StudentLastName10" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Department", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Department1", "teacher1@example.com", "TeacherFirstName1", "TeacherLastName1" },
                    { 2, "Department2", "teacher2@example.com", "TeacherFirstName2", "TeacherLastName2" },
                    { 3, "Department3", "teacher3@example.com", "TeacherFirstName3", "TeacherLastName3" },
                    { 4, "Department4", "teacher4@example.com", "TeacherFirstName4", "TeacherLastName4" },
                    { 5, "Department5", "teacher5@example.com", "TeacherFirstName5", "TeacherLastName5" },
                    { 6, "Department6", "teacher6@example.com", "TeacherFirstName6", "TeacherLastName6" },
                    { 7, "Department7", "teacher7@example.com", "TeacherFirstName7", "TeacherLastName7" },
                    { 8, "Department8", "teacher8@example.com", "TeacherFirstName8", "TeacherLastName8" },
                    { 9, "Department9", "teacher9@example.com", "TeacherFirstName9", "TeacherLastName9" },
                    { 10, "Department10", "teacher10@example.com", "TeacherFirstName10", "TeacherLastName10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherLogin");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
