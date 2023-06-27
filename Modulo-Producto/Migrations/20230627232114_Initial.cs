using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modulo_Producto.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoBarra = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioCosto = table.Column<float>(type: "REAL", nullable: true),
                    PrecioMayoreo = table.Column<float>(type: "REAL", nullable: true),
                    PrecioVenta = table.Column<float>(type: "REAL", nullable: true),
                    Impuestos = table.Column<float>(type: "REAL", nullable: true),
                    TieneInventario = table.Column<bool>(type: "INTEGER", nullable: false),
                    CantidadActual = table.Column<int>(type: "INTEGER", nullable: true),
                    Minimo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
