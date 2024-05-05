using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentAssignmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentAssignments",
                columns: new[] { "AssignmentId", "StudentId", "AssignmentFileLink", "Comment", "CreatedByUserId", "CreatedOn", "IsDeleted", "IsGraded", "ModifiedByUserId", "ModifiedOn", "Score", "Status", "TimeSubmit" },
                values: new object[,]
                {
                    { 1, 6, "https://tripadvisor.com/primis.html", "Revision of Drain Dev in Epididymis/Sperm Cord, Via Opening", null, null, false, false, null, null, 4.76m, 1, new DateTime(2023, 4, 10, 12, 41, 33, 0, DateTimeKind.Utc) },
                    { 1, 7, "http://hatena.ne.jp/erat.png", "Planar Nucl Med Imag of Chest & Neck using Oth Radionuclide", null, null, false, true, null, null, 6.94m, 1, new DateTime(2023, 4, 12, 0, 19, 47, 0, DateTimeKind.Utc) },
                    { 1, 8, "http://buzzfeed.com/at/diam/nam/tristique/tortor/eu/pede.js", "Occlusion of Hemorr Plexus with Intralum Dev, Open Approach", null, null, false, true, null, null, 6.91m, 1, new DateTime(2023, 4, 14, 22, 24, 16, 0, DateTimeKind.Utc) },
                    { 1, 9, "http://senate.gov/in/faucibus/orci.jsp", "Extraction of Left Elbow Bursa and Ligament, Open Approach", null, null, false, true, null, null, 5.05m, 1, new DateTime(2023, 4, 10, 10, 49, 33, 0, DateTimeKind.Utc) },
                    { 1, 10, "http://marriott.com/massa/id/lobortis/convallis/tortor/risus.jpg", "Revision of Autol Sub in L Sternoclav Jt, Perc Endo Approach", null, null, false, false, null, null, 1.06m, 1, new DateTime(2023, 4, 13, 14, 30, 13, 0, DateTimeKind.Utc) },
                    { 1, 11, "http://state.tx.us/in/sapien/iaculis/congue/vivamus/metus/arcu.html", "Revision of Extralum Dev in Great Vessel, Perc Approach", null, null, false, true, null, null, 8.62m, 1, new DateTime(2023, 4, 12, 1, 30, 24, 0, DateTimeKind.Utc) },
                    { 1, 12, null, null, null, null, false, null, null, null, null, 0, null },
                    { 1, 13, null, null, null, null, false, null, null, null, null, 0, null },
                    { 1, 14, null, null, null, null, false, null, null, null, null, 2, null },
                    { 1, 15, null, null, null, null, false, null, null, null, null, 2, null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "AssignmentId", "StudentId" },
                keyValues: new object[] { 1, 15 });

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
    }
}
