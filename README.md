# 🚗 Sistema de Gestión y Renta de Vehículos

## 📖 Descripción

Aplicación de consola desarrollada en **C#** para gestionar una flota de vehículos destinada a servicios de renta.

El sistema permite registrar diferentes tipos de vehículos, consultar su información, buscar vehículos por código, visualizar vehículos según su estado y realizar diferentes operaciones relacionadas con la administración de la flota.

El proyecto fue desarrollado como parte del proceso de aprendizaje de **C# y Programación Orientada a Objetos**.

---

## 🚀 Funcionalidades

El sistema permite:

- Registrar vehículos
- Registrar automóviles
- Registrar camionetas
- Registrar motocicletas
- Mostrar todos los vehículos registrados
- Buscar un vehículo por código
- Mostrar vehículos disponibles
- Mostrar vehículos rentados
- Cambiar el estado de un vehículo
- Identificar el vehículo con mayor kilometraje
- Calcular el precio promedio de renta
- Contar la cantidad de vehículos por tipo
- Realizar mantenimiento a un vehículo
- Consultar información relacionada con el mantenimiento
- Validar los datos ingresados por el usuario
- Navegar mediante un menú interactivo

---

## 🏗️ Estructura del Proyecto

El sistema utiliza una estructura basada en **Programación Orientada a Objetos**.

```text
                    Vehiculo
                       │
          ┌────────────┼────────────┐
          │            │            │
      Automovil     Camioneta    Motocicleta
          │            │            │
          └────────────┼────────────┘
                       │
                IMantenimiento
```

### Clase base

```text
Vehiculo
```

Contiene información general como:

- Código
- Marca
- Modelo
- Año
- Tipo
- Estado
- Kilómetros

---

### Clases derivadas

#### 🚗 Automovil

Incluye características específicas como:

- Número de puertas
- Tipo de transmisión
- Tipo de combustible
- Aire acondicionado
- Número de pasajeros

#### 🚙 Camioneta

Incluye características específicas como:

- Capacidad de carga
- Tipo de tracción
- Doble cabina
- Número de pasajeros

#### 🏍️ Motocicleta

Incluye características específicas como:

- Cilindrada
- Tipo de motocicleta
- Baúl
- Número de cascos

---

## 💡 Conceptos Aplicados

Durante el desarrollo del proyecto se utilizaron los siguientes conceptos:

### 🔹 Fundamentos de C#

- Variables
- Tipos de datos
- Operadores
- Condicionales
- Bucles
- Métodos
- Arreglos
- Cadenas de texto
- Validación de datos

### 🔹 Programación Orientada a Objetos

- Clases
- Objetos
- Encapsulamiento
- Propiedades
- Constructores
- Herencia
- Polimorfismo
- Clases abstractas
- Métodos virtuales
- `override`
- Interfaces
- Casting
- Operador `is`
- Sobrecarga de métodos

---

## 🛠️ Tecnologías Utilizadas

- C#
- .NET
- Aplicación de consola
- Visual Studio Code
- Git
- GitHub

---

## 📋 Menú Principal

```text
========================================
===== SISTEMA DE RENTA DE VEHÍCULOS =====
========================================

1. Registrar vehículo
2. Mostrar todos los vehículos
3. Buscar vehículo por código
4. Mostrar vehículos disponibles
5. Mostrar vehículos rentados
6. Cambiar estado
7. Vehículo con mayor kilometraje
8. Calcular precio promedio de renta
9. Cantidad de vehículos por tipo
10. Realizar mantenimiento
11. Salir
```

---

## 🔎 Ejemplo de Uso

```text
===== REGISTRAR VEHÍCULO =====

1. Automóvil
2. Camioneta
3. Motocicleta

Seleccione una opción: 1

Ingrese el código: 101
Ingrese la marca: Nissan
Ingrese el modelo: Versa
Ingrese el año: 2025
Ingrese el estado: Disponible
Ingrese los kilómetros: 2000
```

El vehículo se almacena dentro del arreglo principal:

```text
Vehiculo[]
```

Esto permite almacenar diferentes tipos de objetos:

```text
Automovil
Camioneta
Motocicleta
```

aprovechando el **polimorfismo**.

---

## 🔧 Mantenimiento

El proyecto utiliza una interfaz para representar comportamientos relacionados con el mantenimiento de los vehículos.

```text
IMantenimiento
```

Cada vehículo puede ejecutar operaciones como:

```text
realizarMantenimiento()
consultarMantenimiento()
```

---

## 📊 Operaciones del Sistema

El programa también permite realizar operaciones sobre toda la flota:

```text
Buscar vehículo
        │
        ▼
Comparar códigos
        │
        ▼
Mostrar información


Consultar disponibilidad
        │
        ▼
Disponible / Rentado


Analizar kilometraje
        │
        ▼
Vehículo con mayor kilometraje


Contar tipos
        │
        ├── Automóviles
        ├── Camionetas
        └── Motocicletas
```

---

## 🧠 Aprendizajes Obtenidos

Este proyecto permitió reforzar conceptos importantes utilizados en el desarrollo de aplicaciones orientadas a objetos:

- Diseño de una jerarquía de clases.
- Reutilización de código mediante herencia.
- Uso de polimorfismo para almacenar diferentes objetos en un mismo arreglo.
- Implementación de interfaces.
- Uso de métodos sobrecargados.
- Validación de entradas del usuario.
- Búsqueda de información mediante ciclos.
- Uso de contadores y acumuladores.
- Organización de la lógica del programa mediante funciones.
- Separación del proyecto en diferentes clases y archivos.

---

## 📂 Posibles Mejoras

Algunas funcionalidades que podrían agregarse en futuras versiones son:

- Modificar información de vehículos.
- Eliminar vehículos.
- Registrar clientes.
- Realizar procesos completos de renta y devolución.
- Calcular costos según el tipo de vehículo.
- Guardar información en archivos.
- Implementar colecciones genéricas como `List<T>`.
- Conectar el sistema con una base de datos.
- Implementar Entity Framework.
- Crear una API.
- Crear una interfaz gráfica o aplicación web.
- Agregar autenticación de usuarios.
- Generar reportes.

---

## 🎯 Objetivo del Proyecto

El objetivo principal de este proyecto fue integrar diferentes conceptos de **C# y Programación Orientada a Objetos** dentro de una aplicación de consola funcional.

El proyecto representa un paso en el desarrollo de aplicaciones más organizadas, escalables y cercanas a sistemas reales utilizados para la gestión de información y recursos.

---

## 👨‍💻 Autor

**Francisco Castillo**

Estudiante y desarrollador en formación, enfocado en fortalecer sus conocimientos en:

- C#
- C++
- Java
- Python
- Programación Orientada a Objetos
- Desarrollo de Software

---

⭐ Si te interesa el proyecto, no dudes en revisarlo y compartir sugerencias o mejoras.