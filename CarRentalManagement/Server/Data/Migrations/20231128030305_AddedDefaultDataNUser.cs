using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataNUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2304b157-83fa-41df-8cc0-e9025a163270", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHWDPNGvXIyN0o+woMPYQsH0p7TWlKApNK3stHwHhOUAwrproOv+m9b7DjvheK5eQA==", null, false, "95568bf4-b9ef-4bbb-afce-88715b41385b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8255), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8256), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8258), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8493), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8494), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8494), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8496), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 11, 28, 11, 3, 5, 30, DateTimeKind.Local).AddTicks(8498), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3849), new DateTime(2023, 11, 28, 10, 48, 47, 576, DateTimeKind.Local).AddTicks(3850) });
        }
    }
}
