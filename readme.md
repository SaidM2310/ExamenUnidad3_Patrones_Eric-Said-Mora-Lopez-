# 🌦️ Aplicación de Clima – Patrón Decorador y Peso Ligero

**Autor:**  
Eric Said Mora López  
21210403  

---

## 📌 Descripción del Proyecto

Este proyecto consiste en una aplicación de consola que simula una App del Clima, permitiendo mostrar distintas condiciones climáticas y aplicar diferentes temas visuales utilizando patrones de diseño.

La aplicación está estructurada en varias clases separadas, siguiendo buenas prácticas de modularidad, y utiliza dos patrones principales:

### ✔ Patrón Decorador
- Permite cambiar dinámicamente el tema visual de la aplicación sin modificar la lógica principal del clima.  
- Se implementan dos temas:
  - **Tema Claro (Azul cielo)**
  - **Tema Oscuro (Azul oscuro)**

### ✔ Patrón Peso Ligero (Flyweight)
- El clima (Soleado, Nublado, Lluvioso, etc.) se almacena y reutiliza mediante una fábrica de objetos compartidos, reduciendo memoria y evitando crear múltiples objetos idénticos.

---

## 🔧 Funcionamiento General

### 1. Clima Inicial Aleatorio
Cuando inicia el programa, se genera un clima al azar usando Flyweight:
- Soleado
- Lluvioso
- Nublado

La temperatura también se genera de forma aleatoria.

### 2. Temas del Sistema (Decorador)
La app permite cambiar dinámicamente el color del fondo:
- **Tema Claro:** Fondo azul cielo
- **Tema Oscuro:** Fondo azul profundo

El decorador envuelve la clase central del clima para modificar únicamente la apariencia.

---

## 🧩 Estructura del Programa

El proyecto está dividido en varios archivos `.cs`, uno por clase:

- `IClima.cs` → Interfaz principal  
- `Clima.cs` → Clase concreta del clima  
- `FabricaClima.cs` → Implementa Flyweight  
- `ITema.cs` → Interfaz del tema  
- `TemaBase.cs` → Clase base del decorador  
- `TemaClaro.cs` → Decorador de tema claro  
- `TemaOscuro.cs` → Decorador de tema oscuro  
- `Program.cs` → Solo contiene llamadas principales  

---

## 📱 Interacción del Usuario

El usuario puede:

- Ver el clima actual  
- Cambiar tema entre claro y oscuro  
- Generar un nuevo clima  
- Salir  

Todo esto mientras reutiliza objetos mediante Flyweight y modifica apariencia con Decorador.

---

## 🎯 Objetivo del Proyecto

- Implementar patrones de diseño **Decorador** y **Flyweight** en un proyecto real.  
- Separar responsabilidades en clases cortas y limpias.  
- Practicar creación de proyectos organizados usando C#.  
- Comprender cómo los patrones ayudan a extender programas sin reescribir código.

---
