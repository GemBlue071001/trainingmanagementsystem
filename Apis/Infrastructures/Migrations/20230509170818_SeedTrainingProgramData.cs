using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedTrainingProgramData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "ParentId", "Status" },
                values: new object[,]
                {
                    { 1, null, null, false, null, null, "Mann-Gutmann", null, 1 },
                    { 2, null, null, false, null, null, "Boyle Inc", null, 1 },
                    { 3, null, null, false, null, null, "Pollich LLC", null, 1 },
                    { 4, null, null, false, null, null, "Murazik, Carroll and Collins", null, 1 },
                    { 5, null, null, false, null, null, "Sipes-Cremin", null, 1 },
                    { 6, null, null, false, null, null, "Streich-Bernier", null, 1 },
                    { 7, null, null, false, null, null, "Goyette, Fahey and Little", null, 1 },
                    { 8, null, null, false, null, null, "MacGyver Group", null, 1 },
                    { 9, null, null, false, null, null, "Adams LLC", null, 1 },
                    { 10, null, null, false, null, null, "Gutmann and Sons", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 8, 18, 130, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 8, 18, 130, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 8, 18, 130, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 8, 18, 130, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 0, 8, 18, 130, DateTimeKind.Local).AddTicks(7788));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1182));
        }
    }
}
