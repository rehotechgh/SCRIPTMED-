using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALENGINE.Migrations
{
    public partial class bnk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory1",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory2",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory3",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory4",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory5",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCategory6",
                table: "Centrals",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiagnosisCategory1",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DiagnosisCategory2",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DiagnosisCategory3",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DiagnosisCategory4",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DiagnosisCategory5",
                table: "Centrals");

            migrationBuilder.DropColumn(
                name: "DiagnosisCategory6",
                table: "Centrals");
        }
    }
}
