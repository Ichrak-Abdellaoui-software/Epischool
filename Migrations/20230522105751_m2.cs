using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApp.MVC.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Classes__CourseI__3E52440B",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK__Classes__Lecture__3D5E1FD2",
                table: "Classes");

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    LecturerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Classes__CourseI__3E52440B",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Classes__Lecture__3D5E1FD2",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id");
                });
        }
    }
}
