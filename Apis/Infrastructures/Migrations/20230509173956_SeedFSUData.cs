using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedFSUData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FSUs",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "Email", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, null, null, "vveque0@adobe.com", false, null, null, "Fix San" },
                    { 2, null, null, "cjermey1@vinaora.com", false, null, null, "Alpha" },
                    { 3, null, null, "pandrivot2@bbb.org", false, null, null, "Redhold" },
                    { 4, null, null, "pleyes3@yolasite.com", false, null, null, "Regrant" },
                    { 5, null, null, "pdawid4@wikipedia.org", false, null, null, "Daltfresh" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 39, 55, 907, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 39, 55, 907, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 39, 55, 907, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 39, 55, 907, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 39, 55, 907, DateTimeKind.Local).AddTicks(3078));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FSUs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FSUs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FSUs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FSUs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FSUs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 17, 56, 702, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 17, 56, 702, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 17, 56, 702, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 17, 56, 702, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 17, 56, 702, DateTimeKind.Local).AddTicks(3122));
        }
    }
}
