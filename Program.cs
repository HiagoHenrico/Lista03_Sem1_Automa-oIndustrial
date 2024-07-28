using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_AutomacaoIndustrial_Sem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex_1 
            Double num;
            Console.WriteLine("Exercício 1 - Crie uma rotina que só aceite numeros positivos.");
            do
            {
                Console.Write("Digite um número positivo: ");
                num = Double.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    //Console.WriteLine("Digite um número positivo: ");
                }

            } while (num <= 0);
                Console.WriteLine("Você digitou {0}", num);

            //Ex_2
            Double num1, num2;
            Console.WriteLine("Exercício 2 - Crie uma rotina que só aceite dois números, mas o segundo deve ser maior que o primeiro.");

            Console.Write("Digite um número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Digite outro número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 <= num1)
                {
                    Console.WriteLine("Inválido! O segundo número deve ser maior que o primeiro.");
                }

            } while (num2 <= num1);
            Console.WriteLine("Você digitou {0} e {1}", num1, num2);

            //Ex_3
            String genero;
            Console.WriteLine("Exercício 3 - Informe o sexo de alguém utilizando M(masculino) e F(feminino).");

            while (true) {
                Console.Write("Informe seu gênero masculino/feminino: ");
                genero = Console.ReadLine().ToUpper();
                if(genero == "F" || genero == "M")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Inválido! Digite apenas M(masculino) ou F(feminino).");
                }
            };
            if(genero == "F")
            {
                Console.WriteLine($"Gênero é {genero}eminino");
            }else if(genero == "M")
            {
                Console.WriteLine($"Gênero é {genero}asculino");
            }else
            {
                Console.WriteLine("Erro!!!?");
            }
            
            //Ex_4
            Console.WriteLine("Exercício 4 - Exibir tabuada do 5.");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}X{i*5}");
            }

            //Ex_5
            Double num_ex5;
            Console.WriteLine("Exercício 5 - Inserir um valor qualquer, travar para apenas aceitar valores positivos. Exibir tabuada até o 10 com o valor inserido.");
            do
            {
                Console.Write("Digite um número positivo: ");
                num_ex5 = Double.Parse(Console.ReadLine());
                if (num_ex5 <= 0)
                {
                    //Console.WriteLine("Digite um número positivo: ");
                }

            } while (num_ex5 <= 0);

            Console.WriteLine($"A tabuada do {num_ex5} é:");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} X {num_ex5*i}",i, num_ex5);
            }

            //Ex_6
            Double num_ex6, indiceTabuada;
            Console.WriteLine("Exercício 6 - ");
            do
            {
                Console.Write("Digite um número positivo: ");
                num_ex6 = Double.Parse(Console.ReadLine());
                Console.Write("Digite o índice da tabuada: ");
                indiceTabuada = Double.Parse(Console.ReadLine());
                if (num_ex6 <= 0)
                {
                    //Console.WriteLine("Digite um número positivo: ");
                }

            } while (num_ex6 <= 0);

            Console.WriteLine($"Tabuada do {num_ex6} - indice {indiceTabuada}:");
            
            for(int i = indiceTabuada;)
            {}

        }
    }
}
