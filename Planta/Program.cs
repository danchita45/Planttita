using System;

class Program
{
    static void Main(string[] args)
    {
        Plant plant = new Plant();

        int waterAmount = 0;
        int bnd =0;
        Console.WriteLine($"Día {0}: {plant.GetGrowthMessage()}");
        Console.WriteLine($"   Humedad: {plant.Humidity}%");
        Console.WriteLine($"   Necesita sol: {plant.NeedsSunlight}");
        Console.WriteLine();
        for (int day = 1; day <= 10; day++)
        {



            Console.Write("Regarás la planta hoy?  Si = 1 No =0 " + day.ToString()+"\n");
            waterAmount = int.Parse(Console.ReadLine());
            
            if (waterAmount > 0)
            {
                Console.WriteLine("se ha regado la planta");
                bnd = 1;
                if (plant.IncreaseHumidity() == 0)
                    break;
            }
            else
            {  
                plant.DecreaseHumidity();
            }

            Console.Write("pondrás la planta al sol? Si = 1 No =0 " + day.ToString()+"\n");
            int opc = int.Parse(Console.ReadLine());

            if (opc != 0)
            {
                Console.Write("se ha puesto la planta al sol " + day.ToString() + "\n");
                bnd= 1;
            }
            else
            {
                plant.CheckSunlight();
            }

            if (bnd == 2)
                plant.Grow();

            Console.WriteLine($"Día {day}: {plant.GetGrowthMessage()}");
            Console.WriteLine($"   Humedad: {plant.Humidity}%");
            Console.WriteLine($"   Necesita sol: {plant.NeedsSunlight}");
            Console.WriteLine();
        }
    }
}


class Plant
{
    private int growthLevel = 0;
    public int Humidity { get; private set; } = 100;
    public int WaterLevel { get; private set; } = 0;
    public bool NeedsSunlight { get; private set; } = false;

    public void Grow()
    {
        growthLevel++;
    }

    public void DecreaseHumidity()
    {
        if (Humidity > 0)
        {
            Humidity -= 10;
        }
    }

    public void CheckSunlight()
    {
        NeedsSunlight = Humidity < 50;
    }

    public string GetGrowthMessage()
    {
        if (growthLevel < 3)
        {
            return "La planta está brotando.";
        }
        else if (growthLevel < 6)
        {
            return "La planta está creciendo saludablemente.";
        }
        else
        {
            return "La planta ha alcanzado su máximo crecimiento.";
        }
    }

    public int IncreaseHumidity()
    {
        int r;
        if (Humidity <= 100)
        {
            Humidity += 10;
            r = 1;
        }
        else
        {
            if (Humidity > 100)
                Console.Write("la planta se ha ahogado, ya tenia toda el agua");

            Console.Write("la planta se ha ahogado" );
            r = 0;
        }
        return r;
    }
}
