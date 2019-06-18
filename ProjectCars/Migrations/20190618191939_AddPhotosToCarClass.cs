using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCars.Migrations
{
    public partial class AddPhotosToCarClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "Cars",
                newName: "PhotoUrl1");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl2",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl3",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl4",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl2",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PhotoUrl3",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PhotoUrl4",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "PhotoUrl1",
                table: "Cars",
                newName: "PhotoUrl");
        }
    }
}
