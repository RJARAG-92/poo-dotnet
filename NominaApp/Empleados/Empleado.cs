namespace NominaApp.Empleados
{
    // ============================
    // Principio de Abstracción
    // ============================
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        protected Empleado(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
        }

        public abstract decimal CalcularSalario();
    }
}
