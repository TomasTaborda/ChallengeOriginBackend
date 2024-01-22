using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class AddExampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "NumeroTarjeta",
                table: "Tarjeta",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Tarjeta",
                columns: new[] { "Id", "Activa", "Balance", "FechaVencimiento", "NumeroTarjeta", "Pin" },
                values: new object[] { 1, true, 1000, new DateOnly(2024, 12, 31), 4512365452557852L, 1234 });

            migrationBuilder.InsertData(
                table: "Movimiento",
                columns: new[] { "IdOperacion", "Fecha", "Monto", "TarjetaId" },
                values: new object[] { 1, new DateTime(2024, 1, 20, 19, 51, 22, 989, DateTimeKind.Local).AddTicks(2935), 50, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movimiento",
                keyColumn: "IdOperacion",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tarjeta",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroTarjeta",
                table: "Tarjeta",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
