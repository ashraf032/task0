using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iki Ededin cemi alqoritmi!");
            Console.WriteLine("---------------");
            Console.WriteLine("Birinci eded Daxil edin");

            string num = Console.ReadLine();
            int a = int.Parse(num);

            Console.WriteLine("---------------");
            Console.WriteLine("Ikinci ededi daxil edin");

            string num2 = Console.ReadLine();
            int b = int.Parse(num2);

            Console.WriteLine("---------------");
            Console.WriteLine(" ");

            Console.WriteLine("Cavab:");

            if (a + b >= 10 && a + b < 100)
            {
                Console.WriteLine("Cem iki reqemlidir");
            }
            else if (a+b>=100 && a + b <1000 )
            {
                Console.WriteLine("Cem uc reqemlidir");
            }
            else
            {
                Console.WriteLine("Nezere alinmayib");
            }
        }
    }
}
