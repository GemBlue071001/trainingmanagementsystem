using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class SeedProgramSyllabusData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProgramSyllabuses",
                columns: new[] { "SyllabusId", "TrainingProgramId", "CreatedByUserId", "CreatedOn", "IsDeleted", "ModifiedByUserId", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 4, null, null, false, null, null },
                    { 1, 9, null, null, false, null, null },
                    { 3, 1, null, null, false, null, null },
                    { 3, 3, null, null, false, null, null },
                    { 3, 8, null, null, false, null, null },
                    { 4, 7, null, null, false, null, null },
                    { 4, 8, null, null, false, null, null },
                    { 6, 2, null, null, false, null, null },
                    { 6, 4, null, null, false, null, null },
                    { 6, 10, null, null, false, null, null },
                    { 7, 1, null, null, false, null, null },
                    { 7, 3, null, null, false, null, null },
                    { 7, 10, null, null, false, null, null },
                    { 8, 5, null, null, false, null, null },
                    { 8, 8, null, null, false, null, null },
                    { 8, 10, null, null, false, null, null },
                    { 9, 3, null, null, false, null, null },
                    { 9, 5, null, null, false, null, null },
                    { 9, 10, null, null, false, null, null },
                    { 10, 2, null, null, false, null, null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "ProgramSyllabuses",
                keyColumns: new[] { "SyllabusId", "TrainingProgramId" },
                keyValues: new object[] { 10, 2 });

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
    }
}
