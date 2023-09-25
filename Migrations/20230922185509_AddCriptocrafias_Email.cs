using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCriptocrafias_Email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1119), "TmHzDJPfm9p1-01qxKwSouR4HZx0TBCPlkXPgpft14=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1227), "Q4k2z1GBf0EiIe4HDqvoxU9i8Bz99ls2g-ZfGPwJJXU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 55, 9, 282, DateTimeKind.Local).AddTicks(1292), "okT5XkZMOtsvuzc8K7U3SqbLj91xB8yaEDk512BhBMA=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6824), "igorpaimdeoliveira@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6864), "Rogeriodeoliveira@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Email" },
                values: new object[] { new DateTime(2023, 9, 22, 15, 44, 37, 697, DateTimeKind.Local).AddTicks(6910), "Magnopaim@gmail.com" });
        }
    }
}
