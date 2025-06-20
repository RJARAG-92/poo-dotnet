// ============================
// Programa principal
// ============================
using InventarioApp.Productos;
using InventarioApp.Servicios;

var inventario = new Inventario();

var leche = new ProductoAlimenticio("Leche entera", 3.50m, DateTime.Now.AddDays(10));
var laptop = new ProductoElectronico("Laptop Dell", 3200m, 24);

inventario.AgregarProducto(leche);
inventario.AgregarProducto(laptop);

inventario.MostrarProductos();