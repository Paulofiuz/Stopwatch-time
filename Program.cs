using System;
using System.Threading;
namespace Stopwatch
{

    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("O = Sair");
            Console.WriteLine("Quanto tem deseja contar?");

            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);    
            
            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int correntTime = 0;

            while (correntTime != time)
            {
                Console.Clear();
                correntTime++;

                Console.WriteLine($"Tempo: {correntTime}");
                Thread.Sleep(1000); // Para ele dormir(Para)
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}