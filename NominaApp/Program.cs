using NominaApp.Empleados;
using NominaApp.Servicios;

List<Empleado> empleados = new List<Empleado>
            {
                new EmpleadoTiempoCompleto("Ana Ramírez", 1, 3500m),
                new EmpleadoPorHoras("Luis Gutiérrez", 2, 120, 25m),
                new EmpleadoTiempoCompleto("Carlos Díaz", 3, 4200m),
                new EmpleadoPorHoras("María Torres", 4, 95, 22m)
            };

ServicioNomina nomina = new ServicioNomina(empleados);
nomina.ImprimirSalarios();