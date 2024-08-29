using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TranslationProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "EndDate", "Name", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, "Description for Project Alpha", new DateTime(2024, 10, 28, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2557), "Project Alpha", new DateTime(2024, 7, 28, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2495), "In Progress" },
                    { 2, "Description for Project Beta", new DateTime(2025, 2, 28, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2562), "Project Beta", new DateTime(2024, 8, 28, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2561), "Not Started" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "Project Manager", "Alice Johnson" },
                    { 2, "Translator", "Bob Smith" },
                    { 3, "Translator", "Charlie Brown" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "GeneratedOn", "ProjectId", "ReportData" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 23, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2603), 1, "Report data for Project Alpha" },
                    { 2, new DateTime(2024, 8, 28, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2605), 2, "Report data for Project Beta" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedTo", "Deadline", "Name", "ProjectId", "Status" },
                values: new object[,]
                {
                    { 1, "Alice Johnson", new DateTime(2024, 8, 18, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2580), "Design UI", 1, "Completed" },
                    { 2, "Bob Smith", new DateTime(2024, 9, 7, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2588), "Develop Backend", 1, "In Progress" },
                    { 3, "Charlie Brown", new DateTime(2024, 9, 17, 19, 16, 43, 273, DateTimeKind.Local).AddTicks(2592), "Gather Requirements", 2, "Not Started" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
