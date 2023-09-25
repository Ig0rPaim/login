using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCriptocrafias_Phone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 56, 30, 709, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 56, 30, 709, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 56, 30, 710, DateTimeKind.Local).AddTicks(85));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1292));
        }
    }
}
