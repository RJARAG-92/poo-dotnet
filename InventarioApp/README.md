# 📦 InventarioApp – Ejemplo de Programación Orientada a Objetos (POO) en C#

Este proyecto forma parte del repositorio `poo-dotnet` y demuestra cómo aplicar los **principios de la Programación Orientada a Objetos (POO)** en un sistema empresarial de control de inventarios.

---

## 🎯 Objetivo

Simular un sistema básico de inventario que gestione distintos tipos de productos (alimenticios y electrónicos), ilustrando cómo aplicar los principios POO en una estructura organizada y mantenible.

---

## 🧱 Principios POO aplicados

| Principio        | Descripción |
|------------------|-------------|
| **Abstracción**  | La clase abstracta `Producto` define atributos comunes y el método `ObtenerDescripcion()`, que las subclases deben implementar. |
| **Herencia**     | `ProductoAlimenticio` y `ProductoElectronico` heredan de `Producto`, permitiendo extender el comportamiento. |
| **Encapsulamiento** | Se ocultan atributos como `FechaVencimiento` y `GarantiaMeses`, exponiendo solo lo necesario mediante métodos públicos. |
| **Polimorfismo** | El inventario gestiona productos de diferentes tipos a través de una lista genérica y ejecuta métodos concretos según el tipo de instancia. |

---

## 🧪 Ejecución

Este es un proyecto de consola. Puedes ejecutarlo directamente desde Visual Studio o CLI:

```bash
dotnet run --project InventarioApp
```

El sistema imprimirá las descripciones detalladas de cada producto registrado en el inventario.

---

## 📂 Estructura del proyecto

```
InventarioApp/
│
├── Productos/
│   ├── Producto.cs              # Clase abstracta base
│   ├── ProductoAlimenticio.cs   # Producto con vencimiento
│   └── ProductoElectronico.cs   # Producto con garantía
│
├── Servicios/
│   └── Inventario.cs            # Clase para gestionar los productos
│
├── Program.cs                   # Punto de entrada
└── README.md                    # Descripción del proyecto
```

---

## 🧠 Aprendizajes clave

- Aplicación de POO con estructuras típicas del dominio empresarial.
- Organización de clases en carpetas temáticas para facilitar mantenibilidad.
- Uso de colecciones y ejecución dinámica de métodos a través del polimorfismo.

---

## 📘 Autor

**Ricardo Jara Gaspar**  
Backend Developer | Arquitectura de Software | .NET Core
