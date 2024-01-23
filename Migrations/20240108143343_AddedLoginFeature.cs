using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InzynierkaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedLoginFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FieldOfStudy",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Students",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 9, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 10, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 11, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 12, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 13, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 14, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 15, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 16, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 17, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 18, 15, 33, 41, 813, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.InsertData(
                table: "TeacherLogin",
                columns: new[] { "TeacherLoginId", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "teacher1@example.com", "haslo123" },
                    { 2, "teacher2@example.com", "haslo123" },
                    { 3, "teacher3@example.com", "haslo123" },
                    { 4, "teacher4@example.com", "haslo123" },
                    { 5, "teacher5@example.com", "haslo123" },
                    { 6, "teacher6@example.com", "haslo123" },
                    { 7, "teacher7@example.com", "haslo123" },
                    { 8, "teacher8@example.com", "haslo123" },
                    { 9, "teacher9@example.com", "haslo123" },
                    { 10, "teacher10@example.com", "haslo123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TeacherLogin",
                keyColumn: "TeacherLoginId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "FieldOfStudy",
                keyValue: null,
                column: "FieldOfStudy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FieldOfStudy",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Department",
                keyValue: null,
                column: "Department",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Students",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 13, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 14, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 15, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 16, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 17, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 18, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 19, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 20, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 21, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 22, 21, 11, 43, 120, DateTimeKind.Local).AddTicks(3183));
        }
    }
}
