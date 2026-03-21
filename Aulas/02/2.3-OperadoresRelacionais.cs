namespace OperadoresRelacionais
{
    class Program
    {
        static void Main()
        {
            /* 
                igualdade ==
                diferente !=
                maior que > 
                menor que <
                maior ou igual >= 
                menor ou igual <=
            */

            //Exemplo
            Console.WriteLine("==========operadores relacionais==============");

            Console.WriteLine("digite o 1º nº: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o 2º nº: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //operador de igualdade (==)
            if (x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }
            Console.WriteLine("\nIgualdade (==): " + result);
        }
    }
}