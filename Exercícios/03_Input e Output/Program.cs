using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Input_e_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Entrada e saída de dados------------------------");

            //Solicitar o nome
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            //solicitar a idade
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            //Saída
            Console.WriteLine("Nome do usuário: " + nome);
            Console.WriteLine("Idade do usuário: " + idade);
        }
    }
}
