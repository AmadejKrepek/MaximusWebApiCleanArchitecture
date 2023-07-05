using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedStationIdAndCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StationData_Stations_Id",
                table: "StationData");

            migrationBuilder.AddColumn<Guid>(
                name: "StationId",
                table: "StationData",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_StationData_StationId",
                table: "StationData",
                column: "StationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StationData_Stations_StationId",
                table: "StationData",
                column: "StationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StationData_Stations_StationId",
                table: "StationData");

            migrationBuilder.DropIndex(
                name: "IX_StationData_StationId",
                table: "StationData");

            migrationBuilder.DropColumn(
                name: "StationId",
                table: "StationData");

            migrationBuilder.AddForeignKey(
                name: "FK_StationData_Stations_Id",
                table: "StationData",
                column: "Id",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
