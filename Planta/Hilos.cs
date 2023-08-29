using System;

class Hilos
{


    public static Thread thread1 = new Thread(CountNumbers);
    public static Thread thread2 = new Thread(CountNumbers2);
    public static Thread thread3;

    
    public void EjemploHilo()
    {

        thread1.Start("Hilo 1");
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Ambos hilos han terminado de contar.");
    }

    static void CountNumbers(object threadName)
    {
        for(int i =0; i < 100; i++)
        {
            Console.WriteLine("Hilo1:" + i.ToString());
            if (i == 50)
            {
                Console.WriteLine("Ya empece a contar el segundo");
                thread2.Start("Hilo 2");

            }

        }
        
    }
    static void CountNumbers2(object threadName)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Hilo2:" + i.ToString());
        }
    }
}
