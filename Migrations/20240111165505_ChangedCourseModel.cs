using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InzynierkaApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_StudentModel",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentModel",
                table: "Students",
                newName: "CourseModelCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentModel",
                table: "Students",
                newName: "IX_Students_CourseModelCourseId");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 11, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 12, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 13, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 14, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 15, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 16, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 17, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 18, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 19, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 20, 17, 55, 3, 993, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseModelCourseId",
                table: "Students",
                column: "CourseModelCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseModelCourseId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "CourseModelCourseId",
                table: "Students",
                newName: "StudentModel");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CourseModelCourseId",
                table: "Students",
                newName: "IX_Students_StudentModel");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 11, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 12, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 13, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 14, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 15, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 16, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 17, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 18, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 19, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2024, 1, 20, 17, 47, 30, 517, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_StudentModel",
                table: "Students",
                column: "StudentModel",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }
    }
}
