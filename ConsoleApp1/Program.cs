using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Hola" + i);
                }
                if (i%5==0)
                {
                    Console.WriteLine("Mundo" + i);
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("HolaMundo" + i);
                }

                Console.WriteLine(i);
            }
            
        }
    }
}
