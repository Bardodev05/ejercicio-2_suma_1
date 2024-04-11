using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔═════════════════════════════════════════════════╗");
        Console.WriteLine("║              ¡Bienvenido a la calculadora!        ║");
        Console.WriteLine("║  Programa para realizar operaciones aritméticas.  ║");
        Console.WriteLine("╚═════════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Antes de continuar, dime tu nombre:");
        string nombreUsuario = Console.ReadLine();
        Console.WriteLine($"¡Hola, {nombreUsuario}!");
        Console.WriteLine();
        Console.WriteLine("Por favor, siga los siguientes pasos:");
        Console.WriteLine("1. Ingrese la cantidad de números a operar.");
        Console.WriteLine("2. Ingrese los números separados por espacios.");
        Console.WriteLine("3. Seleccione la operación a realizar.");
        Console.WriteLine();
        Console.WriteLine("Una vez ingresados los números y seleccionada la operación,");
        Console.WriteLine("el programa mostrará el resultado de la operación.");
        Console.WriteLine();
        Console.WriteLine("¡Comencemos!");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Bienvenido a la calculadora básica.");
            Console.Write("Por favor, ingrese cuántos números desea operar: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            if (cantidadNumeros != 2)
            {
                Console.WriteLine("Esta calculadora solo admite dos operandos. Por favor, intente nuevamente.");
                continue;
            }

            double[] operandos = new double[cantidadNumeros];
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                operandos[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Ingrese el número correspondiente a la operación: ");

            int opcion = int.Parse(Console.ReadLine());
            Operacion operacion = null;
            switch (opcion)
            {
                case 1:
                    operacion = new Suma();
                    break;
                case 2:
                    operacion = new Resta();
                    break;
                case 3:
                    operacion = new Multiplicacion();
                    break;
                case 4:
                    operacion = new Division();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            try
            {
                double resultado = operacion.RealizarOperacion(operandos[0], operandos[1]);
                Console.WriteLine();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║         Resultados del programa          ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine($"El resultado de la operación es: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
            Console.Write("¿Desea realizar otra operación? (S/N): ");
        } while (Console.ReadLine().ToUpper() == "S");

        Console.WriteLine($"Gracias por usar nuestro programa, {nombreUsuario}.");
    }
}