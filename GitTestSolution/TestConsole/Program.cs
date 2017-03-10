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

            ShowMessage("Teste 1");
            ShowMessage("Teste 2");


            Console.ReadLine();


        }

        private static void ShowMessage(String msg)
        {
            Console.WriteLine("A mensagem é: " + msg);
        }
    }
}
