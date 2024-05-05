using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedUnitClassLocationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitClassLocations",
                columns: new[] { "Id", "BuildingLocation", "City", "CreatedByUserId", "CreatedOn", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Room" },
                values: new object[,]
                {
                    { 1, "Subin", 0, null, null, false, null, null, "Meeveo" },
                    { 2, "Stronghold", 0, null, null, false, null, null, "Photobug" },
                    { 3, "Subin", 0, null, null, false, null, null, "Eare" },
                    { 4, "Greenlam", 0, null, null, false, null, null, "Dablist" },
                    { 5, "Zoolab", 0, null, null, false, null, null, "Jetpulse" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 17, 52, 636, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 17, 52, 636, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 17, 52, 636, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 17, 52, 636, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 17, 52, 636, DateTimeKind.Local).AddTicks(7832));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitClassLocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitClassLocations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitClassLocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitClassLocations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitClassLocations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 10, 42, 117, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 10, 42, 117, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 10, 42, 117, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 10, 42, 117, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 10, 42, 117, DateTimeKind.Local).AddTicks(3091));
        }
    }
}
