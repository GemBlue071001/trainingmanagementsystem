using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSubmit",
                table: "StudentAssignments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "StudentAssignments",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<bool>(
                name: "IsGraded",
                table: "StudentAssignments",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 52, 2, 613, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 52, 2, 613, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 52, 2, 613, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 52, 2, 613, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 52, 2, 613, DateTimeKind.Local).AddTicks(281));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSubmit",
                table: "StudentAssignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "StudentAssignments",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsGraded",
                table: "StudentAssignments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 29, 18, 623, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 29, 18, 623, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 29, 18, 623, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 29, 18, 623, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 29, 18, 623, DateTimeKind.Local).AddTicks(7888));
        }
    }
}
