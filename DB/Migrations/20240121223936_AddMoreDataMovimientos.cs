using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDataMovimientos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 1,
                columns: new[] { "Fecha", "Monto" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7524), 1000 });

            migrationBuilder.InsertData(
                table: "Movimiento",
                columns: new[] { "IdOperacion", "Fecha", "Monto", "TarjetaId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7532), 2000, 2 },
                    { 3, new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7533), 50, 3 },
                    { 4, new DateTime(2024, 1, 21, 19, 39, 35, 566, DateTimeKind.Local).AddTicks(7534), 1500, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 1,
                columns: new[] { "Fecha", "Monto" },
                values: new object[] { new DateTime(2024, 1, 21, 13, 42, 50, 83, DateTimeKind.Local).AddTicks(2169), 50 });
        }
    }
}
