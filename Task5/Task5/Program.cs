using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededin edede tam bolunmesi alqoritmi!");
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
            if (a%b==0)
            {
                Console.WriteLine("Tam bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
        }
    }
}
