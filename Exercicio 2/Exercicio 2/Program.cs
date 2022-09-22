using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vendas,vVendas,dif;
            double maior = 0;
            double menor = 0;
            int rec = 0;

            while(rec == 0)
            {
                Console.Clear();
                Console.WriteLine("Quantas vendas foram feitas hoje?");
                vendas = double.Parse(Console.ReadLine());

                for (int i = 1; i <= vendas; i++)
                {
                    Console.WriteLine("Qual o valor da " + i + " venda?");
                    vVendas = double.Parse(Console.ReadLine());

                    if (vVendas > maior)
                    {
                        maior = vVendas;
                        if (i == 1)
                        {
                            menor = vVendas;
                        }
                    }
                    else if (vVendas < menor)
                    {
                        menor = vVendas;
                    }
                }

                dif = maior - menor;

                Console.WriteLine("A maior venda custou $" + maior);
                Console.WriteLine("A menor venda custou $" + menor);
                Console.WriteLine("A diferenca entre eles é de $" + dif);

                Console.WriteLine("Deseja fazer de novo? (0-sim 1-nao)");
                rec = int.Parse(Console.ReadLine());
            }

            Console.Read();
        }
    }
}