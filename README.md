# Práctica - Parcial: Programación Orientada a Objetos en C#

**Institución:** Instituto Tecnológico de Las Américas (ITLA)  
**Asignatura:** Programación 2  
**Docente:** Eduandy Isabel Cruz Abreu  
**Estudiante:** Franklyn Enmanuel Santana Rodríguez (Matrícula: 2025-2089)  

---

## 📌 Descripción del Proyecto
Este proyecto contiene la resolución completa y estructurada de la **Práctica - Parcial** de la asignatura Programación 2, aplicando los fundamentos de la sintaxis en C# y los cuatro pilares esenciales de la Programación Orientada a Objetos (POO).

El código fuente se encuentra debidamente documentado con comentarios claros y explicativos sobre la lógica implementada en cada sección.

---

## 🛠️ Contenido de los Ejercicios Desarrollados

### 1. Sintaxis Básica y Variables
* Mensaje formal de bienvenida al sistema.
* Declaración, asignación e impresión de distintos tipos de datos primitivos (`int`, `string`, `double`, `bool`).

### 2. Estructuras de Control
* Evaluación condicional con operador módulo (`%`) para determinar si un número introducido es par o impar.
* Manejo de entrada interactiva y uso de un bucle `for` para iterar y mostrar los números del 1 al 10.

### 3. Clases y Objetos
* Definición de la clase `Persona` con propiedades para el nombre y la edad.
* Método `Presentarse()` que expone formalmente los datos de la instancia.
* Creación de tres instancias de la clase en el método principal `Main()`.

### 4. Herencia
* Creación de la clase base `Animal` que provee el método virtual `HacerSonido()`.
* Implementación de las clases derivadas `Perro` y `Gato`, heredando las características de la clase base y redefiniendo su sonido característico.

### 5. Polimorfismo
* Uso de colecciones genéricas con `List<Animal>`.
* Recorrido de la lista mediante un ciclo `foreach`, invocando polimórficamente `HacerSonido()` para que cada objeto ejecute su comportamiento especializado.

### 6. Encapsulamiento
* Creación de la clase `CuentaBancaria` con atributo privado `saldo`.
* Implementación de métodos públicos `Depositar(decimal monto)` y `ObtenerSaldo()`, garantizando la validación de montos positivos y la protección del estado interno.

### 7. Interfaces y Abstracción
* Definición del contrato formal `IVehiculo` con los métodos `Encender()` y `Apagar()`.
* Implementación en las clases `Carro` y `Motocicleta`, exhibiendo comportamientos diferenciados en consola.

---

## 🚀 Compilación y Ejecución
Para compilar y ejecutar el proyecto localmente mediante la terminal de .NET:

```bash
# Acceder al directorio del proyecto
cd Practica_Parcial_Prog2

# Ejecutar el programa
dotnet run
```
