namespace array
{
    class Program
    {
        static void Main()
        {
            string separador = "---------------------";
            //1. declaração de array
            string[] frutas = { "macã", "banana", "laranja", "manga" };

            //2. acessar os valores
            Console.WriteLine(frutas[0]);

            Console.WriteLine(separador);

            foreach (string frut in frutas)
            {
                Console.WriteLine(frut);
            }
            Console.WriteLine(separador);
            //3. contagem de indices
            Console.WriteLine("quantidades de indices: " + frutas.Length);

            //4. Alterar os valores
            Console.WriteLine("valores antes da alteração: " + frutas[1]);
            frutas[1] = "morango";
            Console.WriteLine("valores depois da alteração: " + frutas[1]);

            Console.WriteLine(separador);

            //5. declaraçao sem inicializar
            int[] numeros = new int[3];
            n[0] = 10;
            n[1] = 20;
            n[2] = 30;

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}