using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta
{
    public class Viajero
    {
        public void Viaje()
        {
            string[] cities = { "Ciudad A", "Ciudad B", "Ciudad C", "Ciudad D", "Ciudad E", "Ciudad F" };
            int numCities = cities.Length;

            int[,] distances = {
                { 0, 10, 15, 20, 12, 8 },
                { 10, 0, 18, 25, 8, 5 },
                { 15, 18, 0, 30, 20, 10 },
                { 20, 25, 30, 0, 16, 12 },
                { 12, 8, 20, 16, 0, 7 },
                { 8, 5, 10, 12, 7, 0 }
            };

            Console.WriteLine("Bienvenido al Problema del Viajero!");
            Console.WriteLine("Las ciudades disponibles son:");

            for (int i = 0; i < numCities; i++)
            {
                Console.WriteLine($"{i + 1}. {cities[i]}");
            }

            Console.WriteLine("\nSelecciona el orden de visita (1-6) separado por espacios:");
            string[] input = Console.ReadLine().Split(' ');

            List<int> path = new List<int>();

            foreach (string numStr in input)
            {
                if (int.TryParse(numStr, out int cityNumber) && cityNumber >= 1 && cityNumber <= numCities)
                {
                    path.Add(cityNumber - 1);
                }
                else
                {
                    Console.WriteLine($"Entrada inválida: {numStr}");
                    return;
                }
            }

            Console.WriteLine("\nRuta seleccionada:");

            double totalDistance = 0;
            for (int i = 0; i < path.Count - 1; i++)
            {
                int fromCity = path[i];
                int toCity = path[i + 1];
                totalDistance += distances[fromCity, toCity];
                Console.WriteLine($"{cities[fromCity]} -> {cities[toCity]}: {distances[fromCity, toCity]} km");
            }

            Console.WriteLine($"Distancia total de la ruta: {totalDistance} km");
        }
    }
}
