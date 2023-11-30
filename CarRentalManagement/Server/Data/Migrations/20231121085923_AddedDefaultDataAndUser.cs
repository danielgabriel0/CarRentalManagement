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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "68059d77-6823-4f3f-ba06-6ddb6c40046a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBT7SyshYRUlmIS1GcmjAYCA39SrGbOogexV8nqC6EDf/oMyH2Hz1nV4HwafBfaFNQ==", null, false, "e5265155-d895-4338-88ad-506e38ef19db", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6863), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6869), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7432), "BMW", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7434), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 5, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7219), "3 Series", "System" },
                    { 6, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7222), "Prius", "System" },
                    { 7, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7223), "Rav4", "System" },
                    { 8, "System", new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7224), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7225), "X5", "System" }
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
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
