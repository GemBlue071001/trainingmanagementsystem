using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedUnitClassDetailData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitClassDetails",
                columns: new[] { "ClassId", "UnitId", "CreatedByUserId", "CreatedOn", "EndTime", "IsDeleted", "LocationId", "ModifiedByUserId", "ModifiedOn", "StartTime", "TrainerId" },
                values: new object[,]
                {
                    { 4, 1, null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, null, null, new DateTime(2022, 9, 3, 7, 30, 9, 0, DateTimeKind.Utc), 5 },
                    { 4, 2, null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, null, null, new DateTime(2023, 2, 21, 15, 26, 36, 0, DateTimeKind.Utc), 5 },
                    { 4, 3, null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 5, null, null, new DateTime(2023, 2, 2, 3, 29, 27, 0, DateTimeKind.Utc), 5 },
                    { 4, 4, null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, null, null, new DateTime(2023, 1, 10, 18, 1, 5, 0, DateTimeKind.Utc), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 29, 37, 128, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 29, 37, 128, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 29, 37, 128, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 29, 37, 128, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 29, 37, 128, DateTimeKind.Local).AddTicks(8830));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitClassDetails",
                keyColumns: new[] { "ClassId", "UnitId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "UnitClassDetails",
                keyColumns: new[] { "ClassId", "UnitId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "UnitClassDetails",
                keyColumns: new[] { "ClassId", "UnitId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "UnitClassDetails",
                keyColumns: new[] { "ClassId", "UnitId" },
                keyValues: new object[] { 4, 4 });

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
    }
}
