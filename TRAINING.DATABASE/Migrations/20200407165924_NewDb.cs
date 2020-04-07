using Microsoft.EntityFrameworkCore.Migrations;

namespace TRAINING.DATABASE.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yearOneCourses",
                table: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yearOneCourses",
                table: "Student",
                type: "int",
                nullable: true);
        }
    }
}
