using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALENGINE.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANCHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Examination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dispensary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispensaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAppointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimsStatus = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANCHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ANCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Husband = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HusbandContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HusbandOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HusbandAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimsStatus = table.Column<bool>(type: "bit", nullable: true),
                    ANCCount = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Centrals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Examination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dispensary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispensaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAppointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryIntake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfPitTaken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIVStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicklingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centrals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Examination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dispensary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispensaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAppointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimsStatus = table.Column<bool>(type: "bit", nullable: true),
                    HistoryIntake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deliverynote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pulse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SP02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GestationalAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightOfBaby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApgarScoreOfBaby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InitialPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthInsuranceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfFirstVisit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CostPrice = table.Column<double>(type: "float", nullable: false),
                    SalesPrice = table.Column<double>(type: "float", nullable: false),
                    ExpectedSales = table.Column<double>(type: "float", nullable: false),
                    ProfitMargin = table.Column<double>(type: "float", nullable: false),
                    SalesQuantity = table.Column<int>(type: "int", nullable: false),
                    SalesAmount = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CostPrice = table.Column<double>(type: "float", nullable: false),
                    SalesPrice = table.Column<double>(type: "float", nullable: false),
                    SalesQuantity = table.Column<int>(type: "int", nullable: false),
                    SalesAmount = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOSAGE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blood_Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Line1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Next_of_Kin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Next_of_Kin_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Next_of_Kin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthFacilityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPCODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfNearestRelative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactOfNearestRealtive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDistrict_Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfHealthInsuranceScheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthInsuranceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthInsuranceSchemeIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postnatals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Examination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dispensary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispensaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAppointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procedure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DICD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investigation5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IGDRG5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pulse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SP02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonResponsibe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postnatals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VitalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pulse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SP02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANCHistories");

            migrationBuilder.DropTable(
                name: "ANCs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Centrals");

            migrationBuilder.DropTable(
                name: "Consultings");

            migrationBuilder.DropTable(
                name: "DeliveryNotes");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "InitialPayments");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "InventoryTransactions");

            migrationBuilder.DropTable(
                name: "MedicineLists");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "PatientInformations");

            migrationBuilder.DropTable(
                name: "Postnatals");

            migrationBuilder.DropTable(
                name: "VitalInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
