using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
