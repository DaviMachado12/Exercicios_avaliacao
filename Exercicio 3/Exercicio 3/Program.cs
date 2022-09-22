using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] caderno = new string[4, 5];
            int folha, x = 0;
            int repet;
            string nome = "";

            //Preencher as linhas das folhas
            do
            {
                Console.WriteLine("Quer escrever em qual folha? (de 1 a 5)");
                folha = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Folha: " + folha);
                folha -= 1;
                Console.WriteLine();

                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Linha " + (i + 1) + ": ");
                    nome = Console.ReadLine();
                    caderno[i, folha] = nome;
                }

                Console.WriteLine("Quer continuar? (0-sim 1-nao)");
                repet = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (repet == 0);
            
            //Pesquisa
            do
            {
                Console.WriteLine("Pesquise: ");
                string pesquisa = Console.ReadLine();
                Console.Clear();

                for (int f = 0; f <= 4; f++)
                {
                    for (int l = 0; l <= 3; l++)
                    {
                        if (caderno[l, f] == pesquisa)
                        {
                            Console.WriteLine("Folha: " + (f + 1));
                            Console.WriteLine("Linha: " + (l + 1));
                            Console.WriteLine(caderno[l, f]);
                            x = 1;
                        }
                    }
                }
                if (x != 1)
                {
                    Console.WriteLine("Nao Encontrado");
                }

                Console.WriteLine("Quer continuar? (0-sim 1-nao)");
                repet = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (repet == 0);
		}
    }
}
