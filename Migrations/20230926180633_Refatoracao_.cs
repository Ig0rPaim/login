using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class Refatoracao_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BytePassword = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User1", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User1",
                columns: new[] { "Id", "BytePassword", "DataAtualizacao", "DataCadastro", "Email", "Nome", "Phone" },
                values: new object[,]
                {
                    { 1, new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, null, new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6457), "TmHzDJPfm9p1-01qxKwSouR4HZx0_TBCPlkXPgpft14=", "Igor Paim de Oliveira", "yXEftoqMqKFkBvRF8e70wg==" },
                    { 2, new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, null, new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6680), "Q4k2z1GBf0EiIe4HDqvoxU9i8Bz99ls2g-ZfGPwJJXU=", "Rogerio Oliveira", "yXEftoqMqKFkBvRF8e70wg==" },
                    { 3, new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 }, null, new DateTime(2023, 9, 26, 15, 6, 33, 518, DateTimeKind.Local).AddTicks(6783), "okT5XkZMOtsvuzc8K7U3SqbLj91xB8yaEDk512BhBMA=", "Magno Paim", "yXEftoqMqKFkBvRF8e70wg==" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User1");
        }
    }
}
