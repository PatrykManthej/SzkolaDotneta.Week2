using System;

namespace Lesson7.Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zadanie do testowania lub wpisz 0 żeby przetestować wszystkie");
            int ex = Int32.Parse(Console.ReadLine());
            switch (ex)
            {
                case 0:
                    AllEx();
                    break;
                case 1:
                    Ex1();
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    Ex3();
                    break;
                case 4:
                    Ex4();
                    break;
                case 5:
                    Ex5();
                    break;
                case 6:
                    Ex6();
                    break;
                case 7:
                    Ex7();
                    break;
                case 8:
                    Ex8();
                    break;
                case 9:
                    Ex9();
                    break;
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    Ex13();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy numer zadania");
                    break;
            }
        }
        static void Ex1()
        {
            Console.WriteLine("Zadanie nr 1");
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }
        }
        static void Ex2()
        {
            Console.WriteLine("Zadanie nr 2");
            Console.WriteLine("Enter number: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{number} jest liczbą nieparzystą");
            }
        }
        static void Ex3()
        {
            Console.WriteLine("Zadanie nr 3");
            Console.WriteLine("Enter number: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"{number} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($"{number} jest liczbą ujemną");
            }
        }
        static void Ex4()
        {
            Console.WriteLine("Zadanie nr 4");
            Console.WriteLine("Podaj rok");
            int year = Int32.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }
        }
        static void Ex5()
        {
            Console.WriteLine("Zadanie nr 5");
            Console.WriteLine("Podaj swój wiek: ");
            int age = Int32.Parse(Console.ReadLine());
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz zostać posłem lub premierem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem lub senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Jesteś za młody");
            }
        }
        static void Ex6()
        {
            Console.WriteLine("Zadanie nr 6");
            Console.WriteLine("Podaj swój wzrost: ");
            double height = Double.Parse(Console.ReadLine());
            if (height <= 120)
            {
                Console.WriteLine("Jesteś gnomem");
            }
            else if (height > 120 && height <= 150)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height > 150 && height <= 185)
            {
                Console.WriteLine("Jesteś człowiekiem");
            }
            else
            {
                Console.WriteLine("Jesteś nocnym elfem");
            }
        }
        static void Ex7()
        {
            Console.WriteLine("Zadanie nr 7");
            Console.WriteLine("Podaj 3 lczby:");
            int var1 = Int32.Parse(Console.ReadLine());
            int var2 = Int32.Parse(Console.ReadLine());
            int var3 = Int32.Parse(Console.ReadLine());
            if (var1 > var2 && var1 > var3)
            {
                Console.WriteLine($"{var1} jest największa z podanych");
            }
            else if (var2 > var1 && var2 > var3)
            {
                Console.WriteLine($"{var2} jest największa z podanych");
            }
            else
            {
                Console.WriteLine($"{var3} jest największa z podanych");
            }
        }
        static void Ex8()
        {
            Console.WriteLine("Zadanie nr 8");
            Console.WriteLine("Podaj wyniki z matury");
            Console.WriteLine("Matematyka: ");
            int maths = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fizyka: ");
            int physics = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Chemia: ");
            int chemistry = Int32.Parse(Console.ReadLine());

            if (maths + physics + chemistry > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (maths + physics > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (maths <= 70)
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
            else if (physics <= 55)
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
            else if (chemistry <= 45)
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
        }
        static void Ex9()
        {
            Console.WriteLine("Zadanie nr 9");
            Console.WriteLine("Podaj temperaturę");
            double temp = Double.Parse(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }
        }
        static void Ex10()
        {
            Console.WriteLine("Zadanie nr 10");
            Console.WriteLine("Podaj bok a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok c: ");
            int c = Int32.Parse(Console.ReadLine());
            if (a > b && a > c && b + c > a)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (b > a && b > c && a + c > b)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (c > b && c > a && b + a > c)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

        }
        static void Ex11()
        {
            Console.WriteLine("Zadanie nr 11");
            Console.WriteLine("Podaj ocene: ");
            int grade = Int32.Parse(Console.ReadLine());
            switch (grade)
            {
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa ocena");
                    break;
            }
        }
        static void Ex12()
        {
            Console.WriteLine("Zadanie nr 12");
            Console.WriteLine("Podaj numer dnia tygodnia");
            int day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy numer");
                    break;
            }
        }
        static void Ex13()
        {
            Console.WriteLine("Zadanie nr 13");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            double b = Double.Parse(Console.ReadLine());
            int decision;
            do
            {
                Console.WriteLine("Podaj numer operacji do wykonania: \n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie");
                int operation = Int32.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Twój wyniki to: " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Twój wynik to: " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Twój wynik to: " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Twój wynik to: " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy numer operacji");
                        break;
                }

                Console.WriteLine($"Czy chcesz wykonać inną operację na liczbach {a} i {b}? Jeśli tak wpisz 1, jeżeli nie wpisz 0");
                decision = Int32.Parse(Console.ReadLine());
            }
            while (decision == 1);

        }
        static void AllEx()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7();
            Ex8();
            Ex9();
            Ex10();
            Ex11();
            Ex12();
            Ex13();
        }
    }
}
