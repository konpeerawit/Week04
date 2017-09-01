using System;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123456789;
            Console.WriteLine("{0,0:E}",n);
            Console.WriteLine("{0,0:F}",n);
            Console.WriteLine("{0,0:G}",n);
            Console.WriteLine("{0,0:N}",n);
            Console.WriteLine("{0,0:P}",n);
            Console.WriteLine("{0,0:X}",n);
        }
    }
}
