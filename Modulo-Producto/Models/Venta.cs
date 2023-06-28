using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Modulo_Producto.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre cliente")]
        public string Cliente { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Numero Caja")]
        public int Caja { get; set; }

        [Display(Name = "Total")]
        public float? Total { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }
    }
}


