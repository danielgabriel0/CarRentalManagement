using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ControllerRepo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a72f850f-7cf8-4fce-be7f-8565828a3f72", "AQAAAAIAAYagAAAAEEqQXyB/W+N4De3BC70HcdqDvVx8vYDiOPw14mdg314zH3s9auGo35gGIIr26H1c3Q==", "e1f64fda-462b-411b-b1c0-266d40b162fe" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8241), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8627), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 11, 30, 11, 46, 25, 445, DateTimeKind.Local).AddTicks(8629) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56745eee-b80c-4e47-ad48-ca3e1a90b643", "AQAAAAIAAYagAAAAEBelQiA//CHa2VPj7n5Zi2lm1VjUNzGFib0rB5lXKYb/qJ5GIbUUjJ8XLbzZHeLYog==", "ec5de110-1e4a-43be-a536-e2dbcd3c855e" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Model_1",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 11, 30, 11, 18, 44, 946, DateTimeKind.Local).AddTicks(3645) });
        }
    }
}
