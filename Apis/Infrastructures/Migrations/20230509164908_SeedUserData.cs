using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "DateOfBirth", "Discriminator", "Email", "FullName", "Gender", "IsDeleted", "Level", "ModifiedByUserId", "ModifiedOn", "Password", "PhoneNumber", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1130), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "user1@example.com", "User 1", 0, false, "Beginner", null, null, "password", "555-555-1212", 4, 3, "user1" },
                    { 2, 1, new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1173), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "user2@example.com", "User 2", 1, false, "Intermediate", null, null, "password", "555-555-1213", 4, 3, "user2" },
                    { 3, 1, new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1176), new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "user3@example.com", "User 3", 0, false, "Advanced", null, null, "password", "555-555-1214", 4, 3, "user3" },
                    { 4, 1, new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1179), new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "user4@example.com", "User 4", 1, false, "Intermediate", null, null, "password", "555-555-1215", 1, 3, "user4" },
                    { 5, 1, new DateTime(2023, 5, 9, 23, 49, 8, 269, DateTimeKind.Local).AddTicks(1182), new DateTime(1999, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "user5@example.com", "User 5", 0, false, "Beginner", null, null, "password", "555-555-1216", 2, 3, "user5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
