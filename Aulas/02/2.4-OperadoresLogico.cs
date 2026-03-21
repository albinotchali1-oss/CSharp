namespace OperadoresLogico
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("============Operadores lógicos=========");

            bool log = true;
            bool admin = false;

            Console.WriteLine("\ninformações do usuário:");
            Console.WriteLine("logado: " + log);
            Console.WriteLine("acesso ao painel admin: " + admin);

            Console.WriteLine("\npermissões");

            //Operador ou - ||
            if (log || admin)
            {
                Console.WriteLine("Logado");
            }
            else
            {
                Console.WriteLine("acesso ao sistema negado");
            }

            //Operador E - &&
            if (log && admin)
            {
                Console.WriteLine("acesso ao painel de admin");
            }
            else
            {
                Console.WriteLine("acesso ao painel de admin negado");
            }

            //Operador não - !
            if (!log)
            {
                Console.WriteLine("não está logado");
            }
            else
            {
                Console.WriteLine("está logado");
            } 
        }
    }
}