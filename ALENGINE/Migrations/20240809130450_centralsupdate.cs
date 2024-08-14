using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALENGINE.Migrations
{
    public partial class centralsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DICD5",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DICD6",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DIDRG5",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DIDRG6",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis5",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis6",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DICD5",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DICD6",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DIDRG5",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DIDRG6",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "Diagnosis5",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "Diagnosis6",
                table: "Centrals");
        }
    }
}
