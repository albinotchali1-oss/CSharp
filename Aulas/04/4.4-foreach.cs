namespace loopForeach
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}