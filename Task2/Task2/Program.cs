using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Her hansi bir ededin diger edede bolunme shertinin alqrotmi!");
            Console.WriteLine("---------------");
            Console.WriteLine("Bir eded Daxil edin");

            string num = Console.ReadLine();
            int a = int.Parse(num);

            Console.WriteLine("---------------");
            Console.WriteLine("Boleceyiniz ededi daxil edin");

            string num2 = Console.ReadLine();
            int b = int.Parse(num2);

            Console.WriteLine("---------------");
            Console.WriteLine("Cavab:");


            if (a>0)
            {
                if (a % b != 0)
                {
                    Console.WriteLine($"{b} e bolunmur");
                }
                else if (a % 2 != 0)
                {
                    Console.WriteLine($"{b} e bolunen tek ededdir");
                }
                else
                {
                    Console.WriteLine($"{b} bolunen cut ededdir");
                }
            }
            else
            {
                Console.WriteLine("Musbet eded daxil edin!");
            }
        }
    }
}
