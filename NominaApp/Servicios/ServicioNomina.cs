using NominaApp.Empleados;

namespace NominaApp.Servicios
{
    public class ServicioNomina
    {
        private List<Empleado> empleados;

        public ServicioNomina(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }

        public void ImprimirSalarios()
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Salario: {empleado.CalcularSalario()}");
            }
        }
    }
}
