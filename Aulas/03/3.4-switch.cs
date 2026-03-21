namespace EstruturaCondicionalEscolhaCaso
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=============dias de semana=============\n");

            Console.WriteLine("digite um nº de 1 a 7:");
            int dia=Convert.ToInt32(Console.ReadLine());    
            
            switch(dia)
            {
                case 1:
                    Console.WriteLine("domingo");
                    break;    
                case 2:
                    Console.WriteLine("segunda");
                    break;        
                case 3:
                    Console.WriteLine("terça");
                    break;    
                case 4:
                    Console.WriteLine("quarta");
                    break;    
                case 5:
                    Console.WriteLine("quinta");
                    break;    
                case 6:
                    Console.WriteLine("sexta");
                    break;    
                case 7:
                    Console.WriteLine("sabado");
                    break; 
                default:       
                    Console.WriteLine("nº invalido!");
                    break;
            }
        }
    }
}