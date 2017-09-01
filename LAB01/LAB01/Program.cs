using System;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello";
            Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
            Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);
            Console.WriteLine("Hello " + "World");
            Console.WriteLine("Here comes a slash \\");
            Console.WriteLine("|{0, 10}|", 999);
            Console.WriteLine("|{0,-10}|", 000);
            Console.WriteLine("The value: {0}.", 500);
            Console.WriteLine("The value: {0:C}.", 500);
            Console.WriteLine("{0,-10:F4}", 12.3456789);
            Console.WriteLine("{0,-10:C}", 12.3456789);
            Console.WriteLine("{0,-10:E3}", 12.3456789);
            Console.WriteLine("{0,-10:x}", 65535);  // (x = lower case)
            Console.WriteLine("{0,-10:X}", 65535);  // (X = upper case)
               int i;
            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            Console.WriteLine("{0:#.###}.", 1234.56789);
        }
    }
}
