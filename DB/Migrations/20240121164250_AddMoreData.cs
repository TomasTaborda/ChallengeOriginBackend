using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 1, 21, 13, 42, 50, 83, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.InsertData(
                table: "Tarjeta",
                columns: new[] { "Id", "Activa", "Balance", "FechaVencimiento", "NumeroTarjeta", "Pin" },
                values: new object[,]
                {
                    { 2, true, 2000, new DateOnly(2025, 1, 31), 4512365452557853L, 1235 },
                    { 3, false, 3000, new DateOnly(2025, 2, 28), 4512365452557854L, 1236 },
                    { 4, true, 4000, new DateOnly(2025, 3, 31), 4512365452557855L, 1237 },
                    { 5, false, 5000, new DateOnly(2025, 4, 30), 4512365452557856L, 1238 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 1, 20, 19, 51, 22, 989, DateTimeKind.Local).AddTicks(2935));
        }
    }
}
