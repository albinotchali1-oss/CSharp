using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Estrutura_condicional_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========verificador de nºs pares e impares==========");
            Console.WriteLine("digite um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("o numero digitado é par! ");
            }
            else
            {
                Console.WriteLine("o numero é impar! ");
            }
        }
    }
}
