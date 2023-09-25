using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCriptocrafias_Phone_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3697), "yXEftoqMqKFkBvRF8e70wg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3816), "yXEftoqMqKFkBvRF8e70wg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3883), "yXEftoqMqKFkBvRF8e70wg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 56, 30, 709, DateTimeKind.Local).AddTicks(9929), "71999434958" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 56, 30, 709, DateTimeKind.Local).AddTicks(9998), "71999434958" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Phone" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 56, 30, 710, DateTimeKind.Local).AddTicks(85), "71999434958" });
        }
    }
}
