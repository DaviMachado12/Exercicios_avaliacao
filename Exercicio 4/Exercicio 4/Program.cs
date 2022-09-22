using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomep;
            int quant = 0, dsc = 0, repet = 0;
            double valor,total,totald = 0,desc = 0;

            do
            {
                Console.WriteLine("Produto:");
                nomep = Console.ReadLine();

                Console.WriteLine("Quantidade:");
                quant = int.Parse(Console.ReadLine());

                Console.WriteLine("Preco unitario:");
                valor = double.Parse(Console.ReadLine());

                total = valor * quant;

                if (quant <= 5)
                {
                    desc = total * (2.0 / 100.0);
                    dsc = 2;
                }
                else if (quant > 5 && quant <= 10)
                {
                    desc = total * (3.0 / 100.0);
                    dsc = 3;
                }
                else if (quant > 10)
                {
                    desc = total * (5.0 / 100.0);
                    dsc = 5;
                }

                totald = total - desc;

                Console.Clear();

                Console.WriteLine("Produto: " + nomep);
                Console.WriteLine("Preco: " + valor);
                Console.WriteLine("Quantidade: " + quant);
                Console.WriteLine("Total: $" + total);

                Console.WriteLine();

                Console.WriteLine("Por ter comprado " + quant + " unidades do produto " + nomep + ", voce ganha " + dsc + "% de desconto");
                Console.WriteLine("Deixando o valor de $" + total + " para $" + totald);
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("VALOR A PAGAR: $" + totald);

                Console.WriteLine();

                Console.WriteLine("fazer um novo calculo? (1-sim 0-nao)");
                repet = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (repet == 1);
        }
    }
}
