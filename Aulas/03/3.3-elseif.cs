namespace EstruturaCondicionalAninhada
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite sua nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 15)
            {
                Console.WriteLine("Aprovado com excelência.");
            }
            else if (nota >= 10)
            {
                Console.WriteLine("Aprovado.");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Recuperação.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            
            }
        }
    }
}