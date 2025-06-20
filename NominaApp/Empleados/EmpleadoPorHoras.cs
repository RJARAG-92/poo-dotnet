namespace NominaApp.Empleados
{
    // ============================
    // Herencia y Encapsulamiento
    // ============================
    public class EmpleadoPorHoras : Empleado
    {
        private int HorasTrabajadas;
        private decimal TarifaPorHora;

        public EmpleadoPorHoras(string nombre, int id, int horas, decimal tarifa)
            : base(nombre, id)
        {
            HorasTrabajadas = horas;
            TarifaPorHora = tarifa;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
