namespace loopDoWhile
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"Número: {i}");
                i++;
            } while (i <= 5);
        }
    }
}