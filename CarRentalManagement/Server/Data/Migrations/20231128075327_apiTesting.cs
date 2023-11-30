using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class apiTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Make_MakeId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Make",
                table: "Make");

            migrationBuilder.RenameTable(
                name: "Make",
                newName: "Make_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Make_1",
                table: "Make_1",
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
                name: "FK_Vehicles_Make_1_MakeId",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Make_1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Make_1_MakeId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Make_1",
                table: "Make_1");

            migrationBuilder.RenameTable(
                name: "Make_1",
                newName: "Make");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Make",
                table: "Make",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68059d77-6823-4f3f-ba06-6ddb6c40046a", "AQAAAAIAAYagAAAAEBT7SyshYRUlmIS1GcmjAYCA39SrGbOogexV8nqC6EDf/oMyH2Hz1nV4HwafBfaFNQ==", "e5265155-d895-4338-88ad-506e38ef19db" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7224), new DateTime(2023, 11, 21, 16, 59, 22, 975, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Make_MakeId",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
