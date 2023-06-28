using System.ComponentModel.DataAnnotations;
namespace Modulo_Producto.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Codigo de Barra")]
        public string? CodigoBarra { get; set; }

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        [Display(Name = "Precio de Costo (C$)")]
        public float? PrecioCosto { get; set; }

        [Required]
        [Display(Name = "Precio de Mayoreo (C$)")]
        public float? PrecioMayoreo { get; set; }

        [Required]
        [Display(Name = "Precio de Venta (C$)")]
        public float? PrecioVenta { get; set; }

        [Required]
        public float? Impuestos { get; set; }

        [Display(Name = "Tiene Inventario (C$)")]
        public bool TieneInventario { get; set; }

        [Display(Name = "Cantidad actual (C$)")]
        public int? CantidadActual { get; set; }

        public int? Minimo { get; set; }

    }
}
