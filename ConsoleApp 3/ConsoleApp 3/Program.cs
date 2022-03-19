using System;

namespace ConsoleApp_3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Her hansi ededin bir birine bolunub bolunmeme alqoritmi!");
            Console.WriteLine("---------------");
            Console.WriteLine("Bir eded Daxil edin");

            string num = Console.ReadLine();
            int a = int.Parse(num);

            Console.WriteLine("---------------");
            Console.WriteLine("Boleceyiniz ededi daxil edin");

            string num2 = Console.ReadLine();
            int b = int.Parse(num2);

            Console.WriteLine("---------------");
            Console.WriteLine(" ");

            Console.WriteLine("Cavab:");

            if (a % b != 0)
            {
                Console.WriteLine("Bu eded daxil etdiyiniz edede qaliqsiz bolunmur!");
            }
            else

            {
                Console.WriteLine("Bu eded daxil etdiyiniz edede qaliqsiz bolunur!");

            }
        }
    }
}