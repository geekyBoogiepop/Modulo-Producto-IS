namespace Modulo_Producto.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string CodigoBarra { get; set; }

        public string Descripcion { get; set; }

        public float PrecioCosto { get; set; }

        public float PrecioMayoreo { get; set; }

        public float PrecioVenta { get; set; }

        public float Impuestos { get; set; }

        public bool TieneInventario { get; set; }

        public int CantidadActual { get; set; }

        public int Minimo { get; set; }

    }
}
