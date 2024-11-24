using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALENGINE.Migrations
{
    public partial class miv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientInformationId",
                table: "VitalInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientInformationId",
                table: "VitalInfos");
        }
    }
}
