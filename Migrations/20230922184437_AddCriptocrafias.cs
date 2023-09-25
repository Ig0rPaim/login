using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCriptocrafias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.AddColumn<byte[]>(
                name: "BytePassword",
                table: "User",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BytePassword", "DataCadastro" },
                values: new object[] { new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BytePassword", "DataCadastro" },
                values: new object[] { new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BytePassword", "DataCadastro" },
                values: new object[] { new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6910) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BytePassword",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Password" },
                values: new object[] { new DateTime(2023, 9, 14, 11, 53, 38, 95, DateTimeKind.Local).AddTicks(1999), "password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Password" },
                values: new object[] { new DateTime(2023, 9, 14, 11, 53, 38, 95, DateTimeKind.Local).AddTicks(2026), "password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Password" },
                values: new object[] { new DateTime(2023, 9, 14, 11, 53, 38, 95, DateTimeKind.Local).AddTicks(2033), "password" });
        }
    }
}
