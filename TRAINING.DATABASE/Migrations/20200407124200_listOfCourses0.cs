using Microsoft.EntityFrameworkCore.Migrations;

namespace TRAINING.DATABASE.Migrations
{
    public partial class listOfCourses0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yearOneCourses",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yearOneCourses",
                table: "Student");
        }
    }
}
