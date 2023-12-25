using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InzynierkaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedAttendanceList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceList",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsPresent = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceList", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_AttendanceList_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceList_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 7, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 8, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 9, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 10, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 11, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 12, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 13, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 14, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 15, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 16, 16, 30, 10, 441, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceList_CourseId",
                table: "AttendanceList",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceList_StudentId",
                table: "AttendanceList",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceList");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 7, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 8, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 9, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 10, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 11, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 12, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 13, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 14, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 15, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "DateOfClass",
                value: new DateTime(2023, 12, 16, 16, 28, 39, 866, DateTimeKind.Local).AddTicks(7252));
        }
    }
}
