using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o Tempo: ");
            int t = int.Parse(Console.ReadLine());
            Start(t);
        }

        static void Start(int time)
        {

            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");
            Thread.Sleep(2500);
        }
    }
}