# 🧠 poo-dotnet – Ejemplos prácticos de Programación Orientada a Objetos (POO) en C#

Este repositorio contiene una colección de ejemplos diseñados para demostrar la aplicación de los **principios fundamentales de la Programación Orientada a Objetos (POO)** en C#. Cada ejemplo simula un escenario empresarial diferente, implementando los conceptos de **Abstracción, Herencia, Encapsulamiento y Polimorfismo** de forma clara y estructurada.

---

## 🔧 Estructura del repositorio

```
poo-dotnet/
│
├── NominaApp/               # Gestión de nómina y cálculo de salarios
├── GestionDocumentalApp/   # Gestión de documentos empresariales
├── InventarioApp/          # Gestión de productos en inventario
└── README.md               # Descripción general del repositorio
```

---

## 📚 Proyectos incluidos

### ✅ NominaApp
Sistema de cálculo de salarios para diferentes tipos de empleados.
- Aplicación de clases base `Empleado` y derivadas como `EmpleadoTiempoCompleto` y `EmpleadoPorHoras`.
- Polimorfismo mediante el cálculo de salarios en listas de empleados.

### ✅ GestionDocumentalApp
Gestión de documentos (como informes y contratos) en una empresa.
- Uso de clases abstractas como `Documento`.
- Encapsulamiento de detalles internos del contenido y cláusulas.
- Polimorfismo en el resumen dinámico de documentos.

### ✅ InventarioApp
Control de inventario con productos alimenticios y electrónicos.
- Atributos sensibles protegidos (fecha de vencimiento, garantía).
- Herencia desde una clase `Producto`.
- Uso de colecciones polimórficas para gestión unificada.

---

## 🧪 Ejecución
Cada proyecto es una aplicación de consola. Puedes ejecutarlos desde CLI:

```bash
dotnet run --project NominaApp

dotnet run --project GestionDocumentalApp

dotnet run --project InventarioApp
```

---

## 📘 Autor

**Ricardo Jara Gaspar**  
Backend Developer | Arquitectura de Software | .NET Core
