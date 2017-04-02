using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste Git !!!");

            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("  1 - Soma dois numeros ");
            Console.WriteLine("  2 - Multiplica dois numeros ");

            string opc = Console.ReadLine();

            Console.WriteLine("Digite o valor 1: ");
            var valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            var valor2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (opc)
            {

                case "1":
                    resultado = Somar(valor1, valor2);
                    ShowMessage("O resultado é: " + resultado.ToString());
                    break;
                case "2":
                    resultado = Multiplicar(valor1, valor2);
                    ShowMessage("O resultado é: " + resultado.ToString());

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }   

            
            //ShowMessage("Teste 1");
            //ShowMessage("Teste 2");



            Console.ReadLine();


        }

        private static void ShowMessage(String msg)
        {
            Console.WriteLine("A mensagem é: " + msg);
        }

        private static int Multiplicar(int a, int b)
        {
            return (a * b);
        }

        private static int Somar(int a, int b)
        {
            return (a + b);
        }
    }
}
