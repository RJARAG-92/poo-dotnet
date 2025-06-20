# 🧾 NominaApp – Ejemplo de Programación Orientada a Objetos (POO) en C#

Este proyecto forma parte del repositorio `poo-dotnet` y demuestra cómo aplicar los **principios fundamentales de la Programación Orientada a Objetos (POO)** en un sistema empresarial de cálculo de nómina.

---

## 🎯 Objetivo

Simular un sistema de gestión de empleados que calcule el salario de diferentes tipos de empleados utilizando los principios de POO.

---

## 🧱 Principios POO aplicados

| Principio        | Descripción |
|------------------|-------------|
| **Abstracción**  | Se define una clase abstracta `Empleado` que expone la operación `CalcularSalario()` sin preocuparse de su implementación concreta. |
| **Herencia**     | `EmpleadoTiempoCompleto` y `EmpleadoPorHoras` heredan de `Empleado`, reutilizando atributos comunes. |
| **Encapsulamiento** | Los atributos internos como `SalarioMensual` o `TarifaPorHora` están encapsulados y no son accesibles directamente desde fuera. |
| **Polimorfismo** | Se utiliza una lista de tipo `Empleado` para recorrer y ejecutar el método `CalcularSalario()` sin conocer la clase específica. |

---

## 🧪 Ejecución

Este es un proyecto de consola. Puedes ejecutarlo directamente desde Visual Studio o CLI:

```bash
dotnet run --project NominaApp
```

La salida mostrará el salario calculado para cada empleado según su tipo.

---

## 📂 Estructura del proyecto

```
NominaApp/
│
├── Empleados/
│   ├── Empleado.cs                # Clase base abstracta
│   ├── EmpleadoPorHoras.cs        # Subclase concreta
│   └── EmpleadoTiempoCompleto.cs  # Subclase concreta
│
├── Servicios/
│   └── ServicioNomina.cs          # Clase que procesa la nómina
│
├── Program.cs                     # Punto de entrada
└── README.md                      # Descripción del proyecto
```

---

## 🧠 Aprendizajes clave

- Cómo modelar jerarquías usando abstracción y herencia.
- Aplicación práctica del polimorfismo.
- Separación clara de responsabilidades.
- Encapsulamiento de lógica interna de cálculo de salario.

---

## 📘 Autor

**Ricardo Jara Gaspar**  
Backend Developer | Arquitectura de Software | .NET Core
