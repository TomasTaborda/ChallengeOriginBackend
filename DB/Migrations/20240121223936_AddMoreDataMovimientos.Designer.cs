﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(ChallengeContext))]
    [Migration("20240121223936_AddMoreDataMovimientos")]
    partial class AddMoreDataMovimientos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Movimiento", b =>
                {
                    b.Property<int>("IdOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOperacion"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaId")
                        .HasColumnType("int");

                    b.HasKey("IdOperacion");

                    b.HasIndex("TarjetaId");

                    b.ToTable("Movimiento", (string)null);

                    b.HasData(
                        new
                        {
                            IdOperacion = 1,
                            Fecha = new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7524),
                            Monto = 1000,
                            TarjetaId = 1
                        },
                        new
                        {
                            IdOperacion = 2,
                            Fecha = new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7532),
                            Monto = 2000,
                            TarjetaId = 2
                        },
                        new
                        {
                            IdOperacion = 3,
                            Fecha = new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7533),
                            Monto = 50,
                            TarjetaId = 3
                        },
                        new
                        {
                            IdOperacion = 4,
                            Fecha = new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7534),
                            Monto = 1500,
                            TarjetaId = 4
                        });
                });

            modelBuilder.Entity("DB.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activa")
                        .HasColumnType("bit");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaVencimiento")
                        .HasColumnType("date");

                    b.Property<long>("NumeroTarjeta")
                        .HasColumnType("bigint");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tarjeta", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activa = true,
                            Balance = 1000,
                            FechaVencimiento = new DateOnly(2024, 12, 31),
                            NumeroTarjeta = 4512365452557852L,
                            Pin = 1234
                        },
                        new
                        {
                            Id = 2,
                            Activa = true,
                            Balance = 2000,
                            FechaVencimiento = new DateOnly(2025, 1, 31),
                            NumeroTarjeta = 4512365452557853L,
                            Pin = 1235
                        },
                        new
                        {
                            Id = 3,
                            Activa = false,
                            Balance = 3000,
                            FechaVencimiento = new DateOnly(2025, 2, 28),
                            NumeroTarjeta = 4512365452557854L,
                            Pin = 1236
                        },
                        new
                        {
                            Id = 4,
                            Activa = true,
                            Balance = 4000,
                            FechaVencimiento = new DateOnly(2025, 3, 31),
                            NumeroTarjeta = 4512365452557855L,
                            Pin = 1237
                        },
                        new
                        {
                            Id = 5,
                            Activa = false,
                            Balance = 5000,
                            FechaVencimiento = new DateOnly(2025, 4, 30),
                            NumeroTarjeta = 4512365452557856L,
                            Pin = 1238
                        });
                });

            modelBuilder.Entity("DB.Movimiento", b =>
                {
                    b.HasOne("DB.Tarjeta", "Tarjeta")
                        .WithMany("Movimientos")
                        .HasForeignKey("TarjetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tarjeta");
                });

            modelBuilder.Entity("DB.Tarjeta", b =>
                {
                    b.Navigation("Movimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
