using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3848), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3849), new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3850), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
