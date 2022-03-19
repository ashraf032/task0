using System;

namespace Task4
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
            Console.WriteLine(" ");

            Console.WriteLine("Cavab:");
            if (a < 10 && a > -10)
            {
                Console.WriteLine("1 reqemlidir");
            }
            else if (a >= 10 && a < 100 || a <= -10 && a > -100)
            {
                Console.WriteLine("2 reqemlidir");
            }
            else if (a >= 10000 && a < 100000 || a <= -10000 && a > -100000)
            {
                Console.WriteLine("5 reqemlidir");
            }
            else
            {
                Console.WriteLine("Bele bir yoxlanis movcud deyildir");
            }
        }
            
    }
}
