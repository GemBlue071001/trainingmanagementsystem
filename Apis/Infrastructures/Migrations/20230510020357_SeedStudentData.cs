using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 3, 57, 457, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 3, 57, 457, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 3, 57, 457, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 3, 57, 457, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 5, 10, 9, 3, 57, 457, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "DateOfBirth", "Discriminator", "Email", "FullName", "Gender", "IsDeleted", "Level", "ModifiedByUserId", "ModifiedOn", "Password", "PhoneNumber", "Role", "Status", "TrainingClassId", "UserName" },
                values: new object[,]
                {
                    { 6, null, null, null, "Student", "gkitley5@walmart.com", "Georges Kitley", 0, false, "Century", null, null, "YKuiCBqHNZU", "9945804139", 4, 3, 4, "gkitley5" },
                    { 7, null, null, null, "Student", "asupple6@eepurl.com", "Arlinda Supple", 0, false, "TrailBlazer", null, null, "4CoeQvR", "7375167719", 4, 3, 4, "asupple6" },
                    { 8, null, null, null, "Student", "pcanto7@irs.gov", "Prudence Canto", 0, false, "Sienna", null, null, "lFoCGG", "2195699692", 4, 3, 4, "pcanto7" },
                    { 9, null, null, null, "Student", "gfugere8@cbc.ca", "Giavani Fugere", 0, false, "Corvette", null, null, "phNbllvMJtp", "7301345872", 4, 3, 4, "gfugere8" },
                    { 10, null, null, null, "Student", "jfone9@blog.com", "Jasen Fone", 0, false, "Soul", null, null, "6UbhxiJ5MuqQ", "1643273348", 4, 3, 4, "jfone9" },
                    { 11, null, null, null, "Student", "ofacera@yellowbook.com", "Othilia Facer", 1, false, "3500 Club Coupe", null, null, "AKXq1GK", "3497504380", 4, 3, 4, "ofacera" },
                    { 12, null, null, null, "Student", "lconnorsb@cbslocal.com", "Loralee Connors", 1, false, "Galant", null, null, "fF49lx", "4891190366", 4, 3, 4, "lconnorsb" },
                    { 13, null, null, null, "Student", "cohearnc@ft.com", "Creighton O'Hearn", 1, false, "911", null, null, "QSg7QuJnG", "6795687417", 4, 3, 4, "cohearnc" },
                    { 14, null, null, null, "Student", "pmessittd@amazonaws.com", "Padraic Messitt", 1, false, "Cooper Clubman", null, null, "ktFp8NnlOKb", "5959334108", 4, 3, 4, "pmessittd" },
                    { 15, null, null, null, "Student", "lmuffine@whitehouse.gov", "Lesly Muffin", 1, false, "CX-9", null, null, "BFibYI4e4Xu", "8541984843", 4, 3, 4, "lmuffine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

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
    }
}
