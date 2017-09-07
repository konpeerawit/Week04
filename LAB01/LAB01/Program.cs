using System;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastname;
            int id;
            double gpa;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your lastname : ");
            lastname = Console.ReadLine();
            Console.Write("Enter your id student : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter your GPA : ");
            gpa = double.Parse(Console.ReadLine());

            Console.WriteLine("Name : {0} {1}", name, lastname);
            Console.WriteLine("ID   : {0}", id);
            Console.WriteLine("GPA  : {0}", gpa);
            Console.ReadKey();
        }
    }
}
