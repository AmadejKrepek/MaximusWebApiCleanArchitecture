using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedStationTableWithColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "Altitude",
                table: "Stations",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConnectionStatus",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Stations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Stations",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Stations",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitOfMeasurement",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altitude",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "ConnectionStatus",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasurement",
                table: "Stations");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
