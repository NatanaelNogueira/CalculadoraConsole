using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            string escolha;

            Console.Write(Operacoes.Soma(10,50));
            Console.Write(Operacoes.Soma(5, 5));

            Console.Write("Digite um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um operação:");
            Console.WriteLine("A - Soma");
            Console.WriteLine("B - Subtração");
            Console.WriteLine("C - Multiplicação");
            Console.WriteLine("D - Divisão");
            Console.WriteLine("");

            escolha = Console.ReadLine();


            if (escolha.Length == 1)
            {
                switch (escolha.ToUpper())
                {
                    case "A":
                        Console.WriteLine($"A Soma dos dois numeros é : { Operacoes.Soma(n1,n2) }");
                        break;
                    case "B":
                        Console.WriteLine($"A Subtração dos dois numeros é : { Operacoes.Subtracao(n1,n2) }");
                        break;
                    case "C":
                        Console.WriteLine($"A Multiplicação dos dois numeros é : { Operacoes.Multiplicacao(n1, n2)}");
                        break;
                    case "D":
                        Console.WriteLine($"A Divisão dos dois numeros é : { Operacoes.Divisao(n1, n2) }");
                        break;

                    default:
                        Console.WriteLine("FATAL ERROR! : Você escolheu uma opção invalida! Tente novamente");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR.");
            }

            Console.WriteLine("");
            Console.WriteLine("Digite uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
