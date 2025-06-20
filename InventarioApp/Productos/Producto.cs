namespace InventarioApp.Productos
{
    // ============================
    // Abstracción
    // ============================
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        protected Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract string ObtenerDescripcion();
    }
}
