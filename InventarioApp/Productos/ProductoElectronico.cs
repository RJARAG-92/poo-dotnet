namespace InventarioApp.Productos
{
    // ============================
    // Herencia y Encapsulamiento
    // ============================
    public class ProductoElectronico : Producto
    {
        private int GarantiaMeses;

        public ProductoElectronico(string nombre, decimal precio, int garantiaMeses)
            : base(nombre, precio)
        {
            GarantiaMeses = garantiaMeses;
        }

        public override string ObtenerDescripcion()
        {
            return $"[Electrónico] {Nombre} - Precio: {Precio:C} - Garantía: {GarantiaMeses} meses";
        }
    }
}
