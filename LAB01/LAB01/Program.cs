using System;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Enter Integer");
            N = int.Parse(Console.ReadLine());
            bool a = randomNumber > N;
            Console.WriteLine("{0}", a);
            Console.ReadKey();
        }
    }
}
