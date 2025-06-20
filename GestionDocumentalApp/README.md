# 📄 GestionDocumentalApp – Ejemplo de Programación Orientada a Objetos (POO) en C#

Este proyecto forma parte del repositorio `poo-dotnet` y demuestra cómo aplicar los **principios de la Programación Orientada a Objetos (POO)** en un sistema de gestión de documentos empresariales.

---

## 🎯 Objetivo

Simular un sistema documental donde se gestionan distintos tipos de documentos como informes y contratos, usando los principios fundamentales de POO.

---

## 🧱 Principios POO aplicados

| Principio        | Descripción |
|------------------|-------------|
| **Abstracción**  | La clase abstracta `Documento` define el método `MostrarResumen()` que cada tipo de documento debe implementar. |
| **Herencia**     | `Informe` y `Contrato` heredan de `Documento`, reutilizando el comportamiento común e implementando su propia versión del resumen. |
| **Encapsulamiento** | Atributos como `contenido` y `clausulas` están protegidos y modificables solo mediante métodos controlados. |
| **Polimorfismo** | El gestor de documentos maneja una lista de objetos `Documento` y puede invocar `MostrarResumen()` sin conocer su tipo exacto. |

---

## 🧪 Ejecución

Este es un proyecto de consola. Puedes ejecutarlo directamente desde Visual Studio o CLI:

```bash
dotnet run --project GestionDocumentalApp
```

La salida mostrará los resúmenes generados para cada documento gestionado.

---

## 📂 Estructura del proyecto

```
GestionDocumentalApp/
│
├── Documentos/
│   ├── Documento.cs            # Clase abstracta base
│   ├── Informe.cs              # Documento tipo informe
│   └── Contrato.cs             # Documento tipo contrato
│
├── Servicios/
│   └── GestorDocumentos.cs     # Clase que gestiona una lista de documentos
│
├── Program.cs                  # Punto de entrada
└── README.md                   # Descripción del proyecto
```

---

## 🧠 Aprendizajes clave

- Cómo estructurar una jerarquía de clases para representar entidades del dominio.
- Uso del polimorfismo para recorrer objetos heterogéneos con una interfaz común.
- Buenas prácticas de encapsulamiento en clases orientadas a objetos.

---

## 📘 Autor

**Ricardo Jara Gaspar**  
Backend Developer | Arquitectura de Software | .NET Core
