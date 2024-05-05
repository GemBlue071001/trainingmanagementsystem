using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedTrainingClassData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "Status", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[,]
                {
                    { 1, null, 2, "FAPE", 1, "Flowdesk", new DateTime(2023, 2, 25, 10, 39, 47, 0, DateTimeKind.Utc), new DateTime(2022, 9, 8, 20, 59, 11, 0, DateTimeKind.Utc), null, null, 5, false, null, null, 20, 14, 13, null, 2, 1, null, null },
                    { 2, null, 1, "KMKC", 2, "Mat Lam Tam", new DateTime(2023, 1, 31, 6, 41, 15, 0, DateTimeKind.Utc), new DateTime(2022, 10, 7, 17, 20, 30, 0, DateTimeKind.Utc), null, null, 3, false, null, null, 15, 21, 22, null, 2, 2, null, null },
                    { 3, null, 3, "SVJC", 0, "Tin", new DateTime(2023, 3, 22, 10, 16, 43, 0, DateTimeKind.Utc), new DateTime(2023, 3, 20, 23, 35, 57, 0, DateTimeKind.Utc), null, null, 3, false, null, null, 14, 22, 24, null, 1, 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[] { 4, null, 0, "PADG", 2, "Stronghold", new DateTime(2022, 9, 10, 17, 9, 46, 0, DateTimeKind.Utc), new DateTime(2022, 8, 24, 20, 38, 52, 0, DateTimeKind.Utc), null, null, 2, false, null, null, 18, 12, 26, null, 4, null, null });

            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "Status", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[,]
                {
                    { 5, null, 2, "SSVR", 0, "Daltfresh", new DateTime(2022, 5, 13, 16, 41, 20, 0, DateTimeKind.Utc), new DateTime(2022, 12, 5, 3, 8, 19, 0, DateTimeKind.Utc), null, null, 2, false, null, null, 11, 27, 30, null, 2, 5, null, null },
                    { 6, null, 2, "FPC", 1, "Tampflex", new DateTime(2023, 4, 25, 1, 53, 45, 0, DateTimeKind.Utc), new DateTime(2022, 7, 28, 3, 22, 58, 0, DateTimeKind.Utc), null, null, 1, false, null, null, 28, 20, 20, null, 1, 6, null, null },
                    { 7, null, 2, "1V6", 2, "Zontrax", new DateTime(2023, 3, 31, 21, 2, 42, 0, DateTimeKind.Utc), new DateTime(2022, 8, 14, 2, 40, 58, 0, DateTimeKind.Utc), null, null, 5, false, null, null, 26, 28, 25, null, 1, 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[] { 8, null, 3, "PCC", 0, "Trippledex", new DateTime(2022, 7, 18, 11, 19, 29, 0, DateTimeKind.Utc), new DateTime(2023, 2, 6, 22, 26, 51, 0, DateTimeKind.Utc), null, null, 2, false, null, null, 21, 13, 25, null, 8, null, null });

            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "Status", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[] { 9, null, 3, "LATI", 0, "Home Ing", new DateTime(2022, 6, 24, 21, 22, 29, 0, DateTimeKind.Utc), new DateTime(2022, 12, 20, 16, 32, 6, 0, DateTimeKind.Utc), null, null, 4, false, null, null, 25, 10, 11, null, 2, 9, null, null });

            migrationBuilder.InsertData(
                table: "TrainingClasses",
                columns: new[] { "Id", "ApprovedOn", "AttendeeType", "ClassCode", "ClassLocation", "ClassName", "ClassTimeEnd", "ClassTimeStart", "CreatedByUserId", "CreatedOn", "FSUId", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "NumberAttendeeAccepted", "NumberAttendeeActual", "NumberAttendeePlanned", "ReviewedOn", "TrainingProgramId", "UserApprovedId", "UserReviewedId" },
                values: new object[] { 10, null, 1, "ENFG", 0, "Tampflex", new DateTime(2022, 10, 12, 0, 28, 59, 0, DateTimeKind.Utc), new DateTime(2022, 8, 30, 19, 19, 46, 0, DateTimeKind.Utc), null, null, 3, false, null, null, 24, 16, 12, null, 10, null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingClasses",
                keyColumn: "Id",
                keyValue: 10);

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
    }
}
