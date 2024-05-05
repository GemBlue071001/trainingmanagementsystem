using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedClassAdminData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassAdmins",
                columns: new[] { "TrainingClassId", "UserId", "CreatedByUserId", "CreatedOn", "IsDeleted", "ModifiedByUserId", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 4, null, null, false, null, null },
                    { 2, 4, null, null, false, null, null },
                    { 3, 4, null, null, false, null, null },
                    { 4, 4, null, null, false, null, null },
                    { 5, 4, null, null, false, null, null },
                    { 6, 4, null, null, false, null, null },
                    { 7, 4, null, null, false, null, null },
                    { 8, 4, null, null, false, null, null },
                    { 9, 4, null, null, false, null, null },
                    { 10, 4, null, null, false, null, null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ClassAdmins",
                keyColumns: new[] { "TrainingClassId", "UserId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 2, 28, 519, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 2, 28, 519, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 2, 28, 519, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 2, 28, 519, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 1, 2, 28, 519, DateTimeKind.Local).AddTicks(7711));
        }
    }
}
