using System;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Press a key followed by ENTER:");
            ch = (char)Console.Read();  // get a char
            Console.WriteLine("Your key is: " + ch);
        }
    }
}
