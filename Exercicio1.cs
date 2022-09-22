using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA DO 1 AO 10\n");
            for(int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine(x + " x " + y + " = " + x * y);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
