using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class Refatoracao_roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "User1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Role" },
                values: new object[] { new DateTime(2023, 9, 27, 17, 4, 9, 696, DateTimeKind.Local).AddTicks(1199), "manager" });

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Role" },
                values: new object[] { new DateTime(2023, 9, 27, 17, 4, 9, 696, DateTimeKind.Local).AddTicks(1288), "client" });

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Role" },
                values: new object[] { new DateTime(2023, 9, 27, 17, 4, 9, 696, DateTimeKind.Local).AddTicks(1404), "client" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "User1");

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "User1",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6783));
        }
    }
}
