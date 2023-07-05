using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class StationDataTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StationData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Temperature = table.Column<double>(type: "double", nullable: true),
                    Dewpoint = table.Column<double>(type: "double", nullable: true),
                    Humidity = table.Column<double>(type: "double", nullable: true),
                    WindSpeed = table.Column<double>(type: "double", nullable: true),
                    WindGust = table.Column<double>(type: "double", nullable: true),
                    WindDirection = table.Column<int>(type: "int", nullable: true),
                    DailyRain = table.Column<double>(type: "double", nullable: true),
                    SolarRadiation = table.Column<double>(type: "double", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationData_Stations_Id",
                        column: x => x.Id,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StationData");
        }
    }
}
