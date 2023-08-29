using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta
{
    public class Operaciones
    {


        public void Oper()
        {
            while (true)
            {
                Console.WriteLine("Calculadora con Threads");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 5)
                    break;

                Console.Write("Ingresa el primer número (máximo tres dígitos): ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa el segundo número (máximo tres dígitos): ");
                int num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalculateWithThread(() => Console.WriteLine($"Resultado: {num1 + num2}"));
                        break;
                    case 2:
                        CalculateWithThread(() => Console.WriteLine($"Resultado: {num1 - num2}"));
                        break;
                    case 3:
                        CalculateWithThread(() => Console.WriteLine($"Resultado: {num1 * num2}"));
                        break;
                    case 4:
                        if (num2 == 0)
                            Console.WriteLine("No se puede dividir entre cero.");
                        else
                            CalculateWithThread(() => Console.WriteLine($"Resultado: {(double)num1 / num2}"));
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void CalculateWithThread(Action action)
        {
            Thread thread = new Thread(() =>
            {
                action.Invoke();
            });

            thread.Start();
            thread.Join();
        }
    }
}

