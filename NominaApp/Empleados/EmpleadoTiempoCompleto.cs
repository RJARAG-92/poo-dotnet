namespace NominaApp.Empleados
{
    // ============================
    // Herencia y Encapsulamiento
    // ============================
    public class EmpleadoTiempoCompleto : Empleado
    {
        private decimal SalarioMensual;

        public EmpleadoTiempoCompleto(string nombre, int id, decimal salarioMensual)
            : base(nombre, id)
        {
            SalarioMensual = salarioMensual;
        }

        public override decimal CalcularSalario()
        {
            return SalarioMensual;
        }
    }
}
