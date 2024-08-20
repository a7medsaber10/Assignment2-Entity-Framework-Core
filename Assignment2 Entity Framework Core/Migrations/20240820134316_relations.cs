using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2_Entity_Framework_Core.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructors",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DeptId",
                table: "Instructors",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DeptId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Courses");
        }
    }
}
