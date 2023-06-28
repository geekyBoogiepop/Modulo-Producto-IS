using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modulo_Producto.Migrations
{
    public partial class ventas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Producto_ProductoId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_ProductoId",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Venta");

            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "Venta",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "Venta",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Venta",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ProductoId",
                table: "Venta",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Producto_ProductoId",
                table: "Venta",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
