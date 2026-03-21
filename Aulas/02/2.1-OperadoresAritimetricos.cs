namespace OperadoresAritimetricos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("==========calculadora Simples========");
            Console.WriteLine("digite o nº 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o nº 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int soma = n1 + n2;
            int sub = n1 - n2;
            int mult = n1 * n2;
            int div = n2 / n1;
            int module = n2 % n1;

            Console.WriteLine("soma: " + soma);
            Console.WriteLine("subtração: " + sub);
            Console.WriteLine("multiplicação: " + mult);
            Console.WriteLine("divião: " + div);
            Console.WriteLine("modulo: " + module);
        }
    }
}