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
             double valor_ex7, valor2_ex7;

             while (true)
             {
                 Console.WriteLine("Exercício 6");
                 Console.Write("Digite um valor positivo: ");
                 valor_ex7 = Convert.ToDouble(Console.ReadLine());

                 if (valor_ex7 > 0)
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                 }
             }

             Console.WriteLine($"Tabuada do número {valor_ex7}:");

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{valor_ex7} x {i} = {valor_ex7 * i}");
             }

             while (true)
             {
                 Console.Write("Digite um valor positivo (X): ");
                 valor2_ex7 = Convert.ToDouble(Console.ReadLine());

                 if (valor2_ex7 > 0)
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                 }
             }

             int intervaloA, intervaloB;

             Console.Write("Digite o valor inicial do intervalo (A): ");
             intervaloA = Convert.ToInt32(Console.ReadLine());

             while (true)
             {
                 Console.Write("Digite o valor final do intervalo (B - deve ser maior que A): ");
                 intervaloB = Convert.ToInt32(Console.ReadLine());

                 if (intervaloB > intervaloA)
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Valor inválido. O valor final do intervalo (B) deve ser maior que o valor inicial (A).");
                 }
             }

             Console.WriteLine($"Tabuada do número {valor2_ex7} no intervalo de {intervaloB} para {intervaloA}:");

             for (int i = intervaloB; i >= intervaloA; i--)
             {
                 Console.WriteLine($"{valor2_ex7} x {i} = {valor2_ex7 * i}");
             }

            //EX_7
            Console.WriteLine("Exercício 7");
             for (int numero_ex7 = 1; numero_ex7 <= 20; numero_ex7++)
             {
                 Console.WriteLine($"Tabuada do número {numero_ex7}:");

                 for (int i = 1; i <= 10; i++)
                 {
                     Console.WriteLine($"{numero_ex7} x {i} = {numero_ex7 * i}");
                 }

                 Console.WriteLine("Pressione qualquer tecla para continuar para a próxima tabuada...");
                 Console.ReadKey();
                 Console.WriteLine(); 
             }
             
            //EX_8
            int soma_ex8 = 0;
            Console.WriteLine("Exercício 8");

            for (int i = 1; i <= 100; i++)
            {
                soma_ex8 += i;
            }

            Console.WriteLine($" 1 a 100 somados é: {soma_ex8}");
            
            //Ex_9
            int num1_ex9 = 1, num2_ex9 = 1;
            Console.WriteLine("Exercício 9");

            Console.WriteLine($"Os trinta primeiros valores da série de Fibonacci:");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(num1_ex9);

                int proximoNumero = num1_ex9 + num2_ex9;

                num1_ex9 = num2_ex9;
                num2_ex9 = proximoNumero;
            }
            
            //Ex_10
            const int qtdValores = 10;
            double maiorValor_ex_10 = double.MinValue;
            double soma_ex10 = 0;

            for (int i = 0; i < qtdValores; i++)
            {
                double valor_ex10;

                Console.WriteLine("Exercício 10");

                while (true)
                {
                    Console.Write($"Digite o {i + 1}º valor positivo: ");
                    if (!double.TryParse(Console.ReadLine(), out valor_ex10) || valor_ex10 <= 0)
                    {
                        Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                    }
                    else
                    {
                        break;
                    }
                }

                if (valor_ex10 > maiorValor_ex_10)
                {
                    maiorValor_ex_10 = valor_ex10;
                }

                soma_ex10 += valor_ex10;
            }

            double media = soma_ex10 / qtdValores;

            Console.WriteLine($"Maior valor inserido: {maiorValor_ex_10}");
            Console.WriteLine($"Soma dos valores: {soma_ex10}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
            
            //Ex_11
            int qtdValores_ex11, positivos_ex11 = 0, negativos_ex11=0;
            double media_ex11, maiorValor_ex11, menorValor_ex11, soma_ex11;

            while (true)
            {
                Console.Write("Digite a quantidade de valores (N) (positiva, mas menor que vinte): ");
                if (!int.TryParse(Console.ReadLine(), out qtdValores_ex11) || qtdValores_ex11 <= 0 || qtdValores_ex11 >= 20)
                {
                    Console.WriteLine("Quantidade inválida. Por favor, digite um valor positivo, mas menor que vinte.");
                }
                else
                {
                    break;
                }
            }

            maiorValor_ex11 = double.MinValue;
            menorValor_ex11 = double.MaxValue;
            soma_ex11 = 0;
            
            for (int i = 0; i < qtdValores_ex11; i++)
            {
                double valor_ex11;

                Console.Write($"Digite o {i + 1}º valor: ");
                if (!double.TryParse(Console.ReadLine(), out valor_ex11))
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número.");
                    i--; 
                    continue;
                }

                if (valor_ex11 > maiorValor_ex11)
                {
                    maiorValor_ex11 = valor_ex11;
                }

                if (valor_ex11 < menorValor_ex11)
                {
                    menorValor_ex11 = valor_ex11;
                }

                soma_ex11 += valor_ex11;

                if (valor_ex11 > 0)
                {
                    positivos_ex11++;
                }
                else if (valor_ex11 < 0)
                {
                    negativos_ex11++;
                }
            }

            media_ex11 = soma_ex11 / qtdValores_ex11;

            double porcentagemPositivos_11 = (double)positivos_ex11 / qtdValores_ex11 * 100;
            double porcentagemNegativos_11 = (double)negativos_ex11 / qtdValores_ex11 * 100;

            Console.WriteLine($"Maior valor inserido: {maiorValor_ex11}");
            Console.WriteLine($"Menor valor inserido: {menorValor_ex11}");
            Console.WriteLine($"Soma dos valores: {soma_ex11}");
            Console.WriteLine($"Média aritmética dos valores: {media_ex11}");
            Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos_11}%");
            Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos_11}%");
            
            //Ex_12
            do
            {
                double maiorValor_ex12 = double.MinValue;
                double menorValor_ex12 = double.MaxValue;
                double soma_ex12 = 0, media_ex12;
                int positivos_ex12 = 0, negativos_ex12 = 0, qtdValores_ex12;
                string resposta_ex12;

                while (true)
                {
                    Console.Write("Digite a quantidade de valores (N) (POSITIVA, MAS MENOR QUE VINTE): ");
                    if (!int.TryParse(Console.ReadLine(), out qtdValores_ex12) || qtdValores_ex12 <= 0 || qtdValores_ex12 >= 20)
                    {
                        Console.WriteLine("Quantidade inválida. Digite um valor positivo, mas menor que vinte.");
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < qtdValores_ex12; i++)
                {
                    double valor_12;

                    Console.Write($"Digite o {i + 1}º valor: ");
                    if (!double.TryParse(Console.ReadLine(), out valor_12))
                    {
                        Console.WriteLine("Valor inválido. Digite um número.");
                        i--; 
                        continue;
                    }

                    if (valor_12 > maiorValor_ex12)
                    {
                        maiorValor_ex12 = valor_12;
                    }

                    if (valor_12 < menorValor_ex12)
                    {
                        menorValor_ex12 = valor_12;
                    }

                    soma_ex12 += valor_12;

                    if (valor_12 > 0)
                    {
                        positivos_ex12++;
                    }
                    else if (valor_12 < 0)
                    {
                        negativos_ex12++;
                    }
                }

                media_ex12 = soma_ex12 / qtdValores_ex12;

                double porcentagemPositivos = (double)positivos_ex12 / qtdValores_ex12 * 100;
                double porcentagemNegativos = (double)negativos_ex12 / qtdValores_ex12 * 100;

                Console.WriteLine($"Maior valor inserido: {maiorValor_ex12}");
                Console.WriteLine($"Menor valor inserido: {menorValor_ex12}");
                Console.WriteLine($"Soma dos valores: {soma_ex12}");
                Console.WriteLine($"Média dos valores: {media_ex12}");
                Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos}%");
                Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos}%");

                Console.Write("Deseja executar o programa novamente? (S/N): ");
                resposta_ex12 = Console.ReadLine().ToUpper();

                if (resposta_ex12 != "S")
                {
                    break;
                }

            } while (true);
            
            //EX_13
            do
            {
                int numero_ex13;
                long fatorial = 1;
                string resposta_ex13;
                while (true)
                {
                    Console.Write("Digite um número para calcular o fatorial: ");
                    if (!int.TryParse(Console.ReadLine(), out numero_ex13) || numero_ex13 < 0)
                    {
                        Console.WriteLine("Erro! Digite um número inteiro não negativo.");
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 1; i <= numero_ex13; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"O fatorial de {numero_ex13} é: {fatorial}");

                Console.Write("Deseja calcular o fatorial de outro número? (S/N): ");
                resposta_ex13 = Console.ReadLine().ToUpper();

                if (resposta_ex13 != "S")
                {
                    break;
                }

            } while (true);


        }
    }
}