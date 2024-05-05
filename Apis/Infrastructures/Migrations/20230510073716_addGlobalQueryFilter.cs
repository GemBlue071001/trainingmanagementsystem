using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class addGlobalQueryFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 14, 37, 15, 748, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 14, 37, 15, 748, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 14, 37, 15, 748, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 14, 37, 15, 748, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 14, 37, 15, 748, DateTimeKind.Local).AddTicks(8477));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 54, 15, 61, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 54, 15, 61, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 54, 15, 61, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 54, 15, 61, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 54, 15, 61, DateTimeKind.Local).AddTicks(5326));
        }
    }
}
