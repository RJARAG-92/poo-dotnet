namespace InventarioApp.Productos
{
    // ============================
    // Herencia y Encapsulamiento
    // ============================
    public class ProductoAlimenticio : Producto
    {
        private DateTime FechaVencimiento;

        public ProductoAlimenticio(string nombre, decimal precio, DateTime vencimiento)
            : base(nombre, precio)
        {
            FechaVencimiento = vencimiento;
        }

        public override string ObtenerDescripcion()
        {
            return $"[Alimento] {Nombre} - Precio: {Precio:C} - Vence: {FechaVencimiento:d}";
        }
    }

}
