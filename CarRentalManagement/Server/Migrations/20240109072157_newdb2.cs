using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Model_1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make_1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de0bfcf9-b27b-4731-89ec-0967e3f2d4b3", "AQAAAAIAAYagAAAAENz/mVfOlhr1MIWuyRGBdE56L/UZaSpMNfC7UGXfEcTy59lG/Eg7LE4KJvxAp3Z9ww==", "dae2f12b-98dd-4a43-9a4c-35a6a01cf9e1" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(4973), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5403), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5405), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 1, 9, 15, 21, 57, 758, DateTimeKind.Local).AddTicks(5408) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Model_1",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make_1",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colour",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfceed6b-955f-4b57-8758-6c662f782a8c", "AQAAAAIAAYagAAAAEKhGN4z6iPBgTwdEWewQlCbyotZblcFL2Y0bWKkMxLapDtSpwfqlvsSPblXDhIhnAQ==", "879e3e2a-ab11-457c-9e44-de8df014db28" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6018), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6641), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6435), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 1, 4, 12, 27, 26, 538, DateTimeKind.Local).AddTicks(6442) });
        }
    }
}
