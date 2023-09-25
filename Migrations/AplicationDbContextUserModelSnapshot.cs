﻿// <auto-generated />
using System;
using LoginAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginAPI.Migrations
{
    [DbContext(typeof(AplicationDbContextUser))]
    partial class AplicationDbContextUserModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoginAPI.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("BytePassword")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BytePassword = new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 },
                            DataCadastro = new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3697),
                            Email = "TmHzDJPfm9p1-01qxKwSouR4HZx0TBCPlkXPgpft14=",
                            Nome = "Igor Paim de Oliveira",
                            Phone = "yXEftoqMqKFkBvRF8e70wg=="
                        },
                        new
                        {
                            Id = 2,
                            BytePassword = new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 },
                            DataCadastro = new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3816),
                            Email = "Q4k2z1GBf0EiIe4HDqvoxU9i8Bz99ls2g-ZfGPwJJXU=",
                            Nome = "Rogerio Oliveira",
                            Phone = "yXEftoqMqKFkBvRF8e70wg=="
                        },
                        new
                        {
                            Id = 3,
                            BytePassword = new byte[] { 91, 170, 97, 228, 201, 185, 63, 63, 6, 130, 37, 11, 108, 248, 51, 27, 126, 230, 143, 216 },
                            DataCadastro = new DateTime(2023, 9, 22, 16, 2, 2, 661, DateTimeKind.Local).AddTicks(3883),
                            Email = "okT5XkZMOtsvuzc8K7U3SqbLj91xB8yaEDk512BhBMA=",
                            Nome = "Magno Paim",
                            Phone = "yXEftoqMqKFkBvRF8e70wg=="
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
