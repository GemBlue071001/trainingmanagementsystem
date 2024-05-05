using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssignmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedOn", "EndTime", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "StartTime", "SyllabusId", "TrainingClassId", "Type" },
                values: new object[,]
                {
                    { 1, "Bypass Right Ureter to Colon, Open Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Koehler's Rockcress", new DateTime(2023, 4, 14, 11, 30, 52, 0, DateTimeKind.Utc), 1, 4, 1 },
                    { 2, "Beam Radiation of Peripheral Nerve using Photons >10 MeV", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Physciella", new DateTime(2023, 4, 10, 19, 57, 38, 0, DateTimeKind.Utc), 1, 4, 2 },
                    { 3, "Revision of Infusion Device in Right Lower Extremity, Open Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Santa Clara Thorn-mint", new DateTime(2023, 4, 14, 10, 58, 57, 0, DateTimeKind.Utc), 1, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedOn", "EndTime", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "StartTime", "SyllabusId", "TrainingClassId" },
                values: new object[] { 4, "Reposition Right Toe Phalangeal Joint with Internal Fixation Device, Percutaneous Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Creeping Charlie", new DateTime(2023, 4, 10, 21, 48, 52, 0, DateTimeKind.Utc), 1, 4 });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedOn", "EndTime", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "StartTime", "SyllabusId", "TrainingClassId", "Type" },
                values: new object[,]
                {
                    { 5, "Coordination/Dexterity Treatment of Integumentary System - Lower Back / Lower Extremity using Orthosis", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Florida Keys Indian Mallow", new DateTime(2023, 4, 11, 15, 47, 44, 0, DateTimeKind.Utc), 1, 4, 3 },
                    { 6, "Dilation of Right External Iliac Artery, Bifurcation, with Four or More Intraluminal Devices, Percutaneous Endoscopic Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Intermediate Needle And Thread", new DateTime(2023, 4, 14, 17, 24, 26, 0, DateTimeKind.Utc), 1, 4, 1 },
                    { 7, "Drainage of Right Upper Extremity Bursa and Ligament with Drainage Device, Percutaneous Endoscopic Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Coenogonium Lichen", new DateTime(2023, 4, 11, 6, 51, 24, 0, DateTimeKind.Utc), 1, 4, 2 },
                    { 8, "Revision of Internal Fixation Device in Right Carpal Joint, Percutaneous Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Windmill Grass", new DateTime(2023, 4, 14, 19, 28, 55, 0, DateTimeKind.Utc), 1, 4, 1 },
                    { 9, "Removal of Internal Fixation Device from Left Humeral Shaft, Open Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Batoko Plum", new DateTime(2023, 4, 13, 23, 34, 19, 0, DateTimeKind.Utc), 1, 4, 1 },
                    { 10, "Bypass Coronary Artery, Two Arteries from Aorta with Zooplastic Tissue, Open Approach", null, null, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, null, null, "Grove Hawthorn", new DateTime(2023, 4, 10, 21, 3, 29, 0, DateTimeKind.Utc), 1, 4, 3 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10);

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
        }
    }
}
