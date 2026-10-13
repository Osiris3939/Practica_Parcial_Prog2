using System;
using System.Collections.Generic;

namespace PracticaParcialProg2
{
    // =========================================================================
    // INSTITUTO TECNOLÓGICO DE LAS AMÉRICAS (ITLA)
    // ASIGNATURA: Programación 2
    // DOCENTE: Eduandy Isabel Cruz Abreu
    // ESTUDIANTE: Franklyn Enmanuel Santana Rodríguez (Matrícula: 2025-2089)
    // PRÁCTICA - PARCIAL
    // =========================================================================

    #region Ejercicio 3: Clases y Objetos
    // Definición de la clase Persona con sus atributos y método de presentación
    public class Persona
    {
        // Propiedades con valores inicializados para mantener el código limpio y seguro
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método encargado de imprimir la presentación formal en consola
        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }
    #endregion

    #region Ejercicios 4 y 5: Herencia y Polimorfismo
    // Clase base para modelar el comportamiento genérico de un animal
    public class Animal
    {
        public string Nombre { get; set; } = string.Empty;

        // Declaramos el método como virtual para permitir que las clases hijas lo sobreescriban
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal emite un sonido característico.");
        }
    }

    // Clase derivada Perro que hereda de Animal
    public class Perro : Animal
    {
        public Perro(string nombre = "Perro")
        {
            Nombre = nombre;
        }

        // Sobrescritura del método HacerSonido con el ladrido específico
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: Guau, guau.");
        }
    }

    // Clase derivada Gato que hereda de Animal
    public class Gato : Animal
    {
        public Gato(string nombre = "Gato")
        {
            Nombre = nombre;
        }

        // Sobrescritura del método HacerSonido con el maullido específico
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: Miau.");
        }
    }
    #endregion

    #region Ejercicio 6: Encapsulamiento
    // Clase CuentaBancaria que resguarda la información financiera del usuario
    public class CuentaBancaria
    {
        // Atributo privado para proteger el saldo y evitar modificaciones indebidas desde afuera
        private decimal saldo;

        public CuentaBancaria(decimal saldoInicial = 0)
        {
            if (saldoInicial > 0)
            {
                saldo = saldoInicial;
            }
        }

        // Método para registrar depósitos garantizando que el monto sea válido
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Depósito realizado con éxito por valor de: RD$ {monto:N2}");
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser mayor a cero.");
            }
        }

        // Método de acceso controlado para consultar el saldo disponible
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
    #endregion

    #region Ejercicio 7: Interfaces y Abstracción
    // Contrato formal que define las acciones obligatorias para cualquier vehículo
    public interface IVehiculo
    {
        void Encender();
        void Apagar();
    }

    // Implementación de la interfaz en la clase Carro
    public class Carro : IVehiculo
    {
        public string Modelo { get; set; } = "Sedán";

        public void Encender()
        {
            Console.WriteLine($"[Carro {Modelo}]: Girando la llave... El motor enciende suavemente y el tablero se ilumina.");
        }

        public void Apagar()
        {
            Console.WriteLine($"[Carro {Modelo}]: Se corta la ignición... El motor se detiene por completo.");
        }
    }

    // Implementación de la interfaz en la clase Motocicleta
    public class Motocicleta : IVehiculo
    {
        public string Cilindrada { get; set; } = "250cc";

        public void Encender()
        {
            Console.WriteLine($"[Motocicleta {Cilindrada}]: Presionando el botón de arranque... El escape ruge de inmediato.");
        }

        public void Apagar()
        {
            Console.WriteLine($"[Motocicleta {Cilindrada}]: Se presiona el interruptor de corte... La moto queda apagada.");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Práctica - Parcial | Programación 2 | ITLA";

            // =================================================================
            // 1. SINTAXIS BÁSICA Y VARIABLES
            // =================================================================
            Console.WriteLine("================================================================================");
            Console.WriteLine("           INSTITUTO TECNOLÓGICO DE LAS AMÉRICAS (ITLA)");
            Console.WriteLine("             PRÁCTICA - PARCIAL DE PROGRAMACIÓN 2 (POO)");
            Console.WriteLine("           Estudiante: Franklyn Enmanuel Santana Rodríguez (2025-2089)");
            Console.WriteLine("================================================================================\n");

            Console.WriteLine(">>> 1. SINTAXIS BÁSICA Y VARIABLES <<<");
            Console.WriteLine("¡Sean cordialmente bienvenidos a la solución de nuestra Práctica Parcial!\n");

            // Declaración e inicialización de variables de distintos tipos de datos
            int cuatrimestreActual = 3;
            string carreraEstudiante = "Desarrollo de Software";
            double indiceAcademico = 3.92;
            bool asignaturasCompletadas = true;

            // Mostramos los valores en consola de manera organizada
            Console.WriteLine($"* Cuatrimestre (int): {cuatrimestreActual}");
            Console.WriteLine($"* Carrera (string): {carreraEstudiante}");
            Console.WriteLine($"* Índice Académico (double): {indiceAcademico}");
            Console.WriteLine($"* ¿Asignaturas al día? (bool): {(asignaturasCompletadas ? "Sí" : "No")}\n");


            // =================================================================
            // 2. ESTRUCTURAS DE CONTROL
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 2. ESTRUCTURAS DE CONTROL <<<");

            // Solicitud interactiva de un número entero con valor seguro por defecto
            Console.Write("Por favor, ingrese un número entero (o presione Enter para usar 8): ");
            string? entradaUsuario = Console.ReadLine();
            int numeroEvaluado;

            if (string.IsNullOrWhiteSpace(entradaUsuario) || !int.TryParse(entradaUsuario, out numeroEvaluado))
            {
                numeroEvaluado = 8; // Valor predeterminado si no se introduce dato
                Console.WriteLine($"Se tomó el valor predeterminado: {numeroEvaluado}");
            }

            // Evaluación condicional para determinar si es par o impar
            if (numeroEvaluado % 2 == 0)
            {
                Console.WriteLine($"Resultado: El número {numeroEvaluado} es PAR.");
            }
            else
            {
                Console.WriteLine($"Resultado: El número {numeroEvaluado} es IMPAR.");
            }

            // Bucle for para imprimir los números secuenciales del 1 al 10
            Console.Write("Secuencia del 1 al 10 generada con bucle for: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + (i < 10 ? ", " : "\n\n"));
            }


            // =================================================================
            // 3. CLASES Y OBJETOS
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 3. CLASES Y OBJETOS <<<");
            Console.WriteLine("Instanciamos tres objetos de la clase Persona y llamamos al método Presentarse():\n");

            // Instanciamos los 3 objetos solicitados en la rúbrica
            Persona persona1 = new Persona("Franklyn Santana", 21);
            Persona persona2 = new Persona("Ana Martínez", 22);
            Persona persona3 = new Persona("Carlos Gómez", 20);

            // Invocación del método Presentarse() en cada instancia
            persona1.Presentarse();
            persona2.Presentarse();
            persona3.Presentarse();
            Console.WriteLine();


            // =================================================================
            // 4. HERENCIA
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 4. HERENCIA <<<");
            Console.WriteLine("Instanciamos clases hijas derivadas de la clase Animal:\n");

            Perro miPerro = new Perro("Firulais");
            Gato miGato = new Gato("Michi");

            // Invocación individual del método de sonido
            miPerro.HacerSonido();
            miGato.HacerSonido();
            Console.WriteLine();


            // =================================================================
            // 5. POLIMORFISMO
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 5. POLIMORFISMO <<<");
            Console.WriteLine("Recorriendo una lista genérica List<Animal> tratando cada objeto polimórficamente:\n");

            // Colección que almacena distintas clases derivadas bajo el tipo común Animal
            List<Animal> listaAnimales = new List<Animal>
            {
                new Perro("Perro Guardián"),
                new Gato("Gato Siamés")
            };

            // Cada elemento ejecuta su propia versión del método HacerSonido()
            foreach (Animal animal in listaAnimales)
            {
                animal.HacerSonido();
            }
            Console.WriteLine();


            // =================================================================
            // 6. ENCAPSULAMIENTO
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 6. ENCAPSULAMIENTO <<<");
            Console.WriteLine("Operaciones bancarias protegiendo el acceso directo al saldo:\n");

            // Creamos una cuenta bancaria con saldo base de RD$ 1,500.00
            CuentaBancaria miCuenta = new CuentaBancaria(1500.00m);
            Console.WriteLine($"Saldo de apertura: RD$ {miCuenta.ObtenerSaldo():N2}");

            // Realizamos un depósito controlado mediante el método público
            miCuenta.Depositar(3500.50m);

            // Consultamos el saldo final verificado
            Console.WriteLine($"Saldo actual consultado: RD$ {miCuenta.ObtenerSaldo():N2}\n");


            // =================================================================
            // 7. INTERFACES Y ABSTRACCIÓN
            // =================================================================
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(">>> 7. INTERFACES Y ABSTRACCIÓN <<<");
            Console.WriteLine("Demostración de cumplimiento de contrato mediante la interfaz IVehiculo:\n");

            IVehiculo vehiculoCarro = new Carro { Modelo = "Honda Civic" };
            IVehiculo vehiculoMoto = new Motocicleta { Cilindrada = "Yamaha R3" };

            // Pruebas del carro
            vehiculoCarro.Encender();
            vehiculoCarro.Apagar();
            Console.WriteLine();

            // Pruebas de la motocicleta
            vehiculoMoto.Encender();
            vehiculoMoto.Apagar();

            Console.WriteLine("\n================================================================================");
            Console.WriteLine("           ¡TODOS LOS EJERCICIOS FUERON EJECUTADOS CON ÉXITO!");
            Console.WriteLine("================================================================================");
        }
    }
}
