using Planta;
using System;

class Program
{
    static void Main(string[] args)
    {
        CE cE = new CE();
        cE.MainnCE();
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
