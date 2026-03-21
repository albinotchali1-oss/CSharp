namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("========Operadores de atribuição===========");

            //inicializar a variável
            int x = 10;
            Console.WriteLine("\nValor inicial da variavel de x: " + x);

            //operadores de atribuição simples (=)
            x = 20;
            Console.WriteLine("\nAtribuição simples");
            Console.WriteLine("valor de x: " + x);

            //atribuição composta
            x++; //equivale a x = x + 1
            Console.WriteLine("\nAtribuição composta incremento (++)" + "\nNovo valor de x: " + x);

            //atribuição composta (+=)
            x += 10; //equivale x = x + 10
            Console.WriteLine("\nAtribuição composta incremento (+=)" + "\nNovo valor de x: " + x);

            //atribuição composta (-=)
            x -= 10; //equivale a x = x - 10
            Console.WriteLine("\nAtribuição composta incremento (-=)" + "\nNovo valor de x: " + x);

            //atribuição composta (*=)
            x *= 10; //equivale a x= x * 10
            Console.WriteLine("\nAtribuição composta incremento (*=)" + "\nNovo valor de x: " + x);

            //atribuição composta (/=)
            x /= 10; //equivale a x= x / 10
            Console.WriteLine("\nAtribuição composta incremento (/=)" + "\nNovo valor de x: " + x);
        }
    }
}