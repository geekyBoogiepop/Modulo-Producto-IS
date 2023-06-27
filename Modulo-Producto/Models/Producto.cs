using System.ComponentModel.DataAnnotations;
namespace Modulo_Producto.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Display(Name = "Codigo de Barra")]
        public string? CodigoBarra { get; set; }

        public string? Descripcion { get; set; }

        [Display(Name = "Precio de Costo")]
        public float? PrecioCosto { get; set; }

        [Display(Name = "Precio de Mayoreo")]
        public float? PrecioMayoreo { get; set; }

        [Display(Name = "Precio de Venta")]
        public float? PrecioVenta { get; set; }

        public float? Impuestos { get; set; }

        [Display(Name = "Tiene Inventario")]
        public bool TieneInventario { get; set; }

        [Display(Name = "Cantidad actual")]
        public int? CantidadActual { get; set; }

        public int? Minimo { get; set; }

    }
}
