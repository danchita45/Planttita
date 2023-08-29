using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta
{
    public class Mochila
    {


        class Item
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }
        }


        static void Main(string[] args)
        {
            int capacity = 15; // Capacidad de la mochila
            int itemCount = 6; // Número de objetos

            Item[] items = new Item[itemCount];

            Console.WriteLine("Ingrese el peso y valor de cada objeto:");

            for (int i = 0; i < itemCount; i++)
            {
                Console.Write($"Objeto {i + 1} - Nombre: ");
                string name = Console.ReadLine();

                Console.Write("Peso: ");
                int weight = int.Parse(Console.ReadLine());

                Console.Write("Valor: ");
                int value = int.Parse(Console.ReadLine());

                items[i] = new Item { Name = name, Weight = weight, Value = value };
            }

            int[,] dp = new int[itemCount + 1, capacity + 1];

            for (int i = 1; i <= itemCount; i++)
            {
                for (int w = 1; w <= capacity; w++)
                {
                    if (items[i - 1].Weight <= w)
                    {
                        dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - items[i - 1].Weight] + items[i - 1].Value);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            Console.WriteLine($"El valor máximo que se puede obtener es: {dp[itemCount, capacity]}");
        }
    }




}
