namespace Input_Output
{
    class Program
    {
        static void Main()
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