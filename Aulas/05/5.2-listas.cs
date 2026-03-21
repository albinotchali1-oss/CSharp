namespace listas
{
    class Program
    {
        static void Main()
        {   
            string separador="========================";
            //Declaração com inicialização de valores
            List<string> frutas = new List<string>()
            {
                "maçã",
                "banana",
                "manga"
            };

            //2. Acessar os valores
            Console.WriteLine(frutas[1]);

            Console.WriteLine(separador);

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

             Console.WriteLine(separador);

            //Adicionando elementos
            frutas.Add("limão");
            frutas.Add("laranja");

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }            
            
            Console.WriteLine(separador);

            //4. Remover Elementos
            fruits.Remove("Limão");

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine(separador);

            //5. Contagem de Elementos
            Console.WriteLine("Quantidade de Frutas: " + frutas.Count);

            Console.WriteLine(separador);

            //6. Modificar um elmentos
            frutas[2] = "Maracujá";

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine(separador);

            //7. Limpar a lista
            frutas.Clear();

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine(separador);

            //8. Declarar sem inicializar
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(50);
            numeros.Add(78);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}