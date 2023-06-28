using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modulo_Producto.Migrations
{
    public partial class venta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PrecioVenta",
                table: "Producto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "PrecioMayoreo",
                table: "Producto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "PrecioCosto",
                table: "Producto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Impuestos",
                table: "Producto",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Producto",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoBarra",
                table: "Producto",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Caja = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<float>(type: "REAL", nullable: false),
                    IdProducto = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venta_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ProductoId",
                table: "Venta",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.AlterColumn<float>(
                name: "PrecioVenta",
                table: "Producto",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<float>(
                name: "PrecioMayoreo",
                table: "Producto",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<float>(
                name: "PrecioCosto",
                table: "Producto",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<float>(
                name: "Impuestos",
                table: "Producto",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Producto",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoBarra",
                table: "Producto",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
