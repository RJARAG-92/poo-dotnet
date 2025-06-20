using InventarioApp.Productos;

namespace InventarioApp.Servicios
{
    // ============================
    // Polimorfismo
    // ============================
    public class Inventario
    {
        private List<Producto> productos = new();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void MostrarProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ObtenerDescripcion());
            }
        }
    }
}
