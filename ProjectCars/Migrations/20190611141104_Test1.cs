using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCars.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }
    }
}
