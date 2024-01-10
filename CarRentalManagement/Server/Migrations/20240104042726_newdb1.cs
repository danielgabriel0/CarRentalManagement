using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1934008a-e09f-4457-ba0a-95a06eafd245", "AQAAAAIAAYagAAAAEBET6lONTl79caAS2cWamiP3SZdhRBtsfA55jFdxRMCosSA9dRhS5qwAVlUHEoDYlg==", "dc8f2b0d-3a4e-4c92-a68f-40360cf10088" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2453), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2911), new DateTime(2024, 1, 4, 12, 5, 27, 111, DateTimeKind.Local).AddTicks(2912) });
        }
    }
}
