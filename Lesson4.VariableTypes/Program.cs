using System;

namespace Lesson4.VariableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            string firstName1;
            string lastName1;
            int age1;
            char gender1;
            int pesel1;
            int employeeNumber1;

            //Ex2
            char vara = 'a';
            char varb = 'b';
            char varc = 'c';
            Console.WriteLine($"{varc} {varb} {vara}");

            //Ex3
            int a = 5;
            int b = 8;
            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Przekątna: {diagonal}");

            //Ex4
            int var1;
            double var2;
            string var3;
            var1 = 10;
            var2 = 12.5;
            var3 = "Szkoła Dotneta";

            //Ex5
            Console.WriteLine("Podaj Imię: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko");
            string lastName = Console.ReadLine();
            Console.WriteLine("Podaj Numer telefonu");
            int phoneNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj mail");
            string mail = Console.ReadLine();
            Console.WriteLine("Podaj wzrost");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wagę");
            double weight = Double.Parse(Console.ReadLine());
        }
    }
}
