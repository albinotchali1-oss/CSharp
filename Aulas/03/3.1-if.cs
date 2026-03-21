namespace EstruturaCondicionalSimples
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
        }
    }
}