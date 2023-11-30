using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Controllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Model_ModelsId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Model_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model_1",
                table: "Model_1",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Model_1_ModelsId",
                table: "Vehicles",
                column: "ModelsId",
                principalTable: "Model_1",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Model_1_ModelsId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model_1",
                table: "Model_1");

            migrationBuilder.RenameTable(
                name: "Model_1",
                newName: "Model");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c66349f-8682-4203-8ff8-b4adcc314bd8", "AQAAAAIAAYagAAAAEGyD9a/dK2qt7ufEuxmngEpWTTR/wMNyfmqOSCTKhSjaoIg0fsM4wat/UNAnkoGLZg==", "8816722d-db42-4b20-8234-c29e8088a6eb" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 674, DateTimeKind.Local).AddTicks(9590), new DateTime(2023, 11, 28, 15, 53, 27, 674, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 674, DateTimeKind.Local).AddTicks(9607), new DateTime(2023, 11, 28, 15, 53, 27, 674, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Make_1",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 11, 28, 15, 53, 27, 675, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Model_ModelsId",
                table: "Vehicles",
                column: "ModelsId",
                principalTable: "Model",
                principalColumn: "Id");
        }
    }
}
