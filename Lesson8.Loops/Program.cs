using System;

namespace Lesson8.Loops
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
                default:
                    Console.WriteLine("Nieprawidłowy numer zadania");
                    break;
            }
        }
        static void Ex1()
        {
            Console.WriteLine("Exercise 1: ");
            int numberOfPrimeNumbers = 0;
            Console.WriteLine("Prime numbers: ");
            for (int number = 0; number <= 100; number++)
            {
                bool isPrime = true;

                if (number < 2)
                {
                    isPrime = false;
                }

                double squareRoot = Math.Sqrt(number);

                for (int divisor = 2; divisor <= squareRoot; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime)
                {
                    numberOfPrimeNumbers++;
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine($"\nNumber of prime numbers: {numberOfPrimeNumbers}");
        }
        static void Ex2()
        {
            Console.WriteLine("Exercise 2: ");
            Console.WriteLine("Even numbers: ");
            int startVar = 0;
            int endVar = 1000;
            int numberOfEvenNumbers = 0;
            do
            {
                if (startVar % 2 == 0)
                {
                    numberOfEvenNumbers++;
                    Console.Write($"{startVar} ");
                }
                startVar++;
            }
            while (startVar <= endVar);
            Console.WriteLine($"\nNumber of even numbers: {numberOfEvenNumbers}");
        }
        static void Ex3()
        {
            Console.WriteLine("Exercise 3: ");
            Console.WriteLine("Enter number of iteration (max 47): ");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci sequence: ");

            int var1 = 0;
            int var2 = 1;
            int var3 = 0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(var3);
                var3 = var1 + var2;
                var2 = var1;
                var1 = var3;
            }
        }
        static void Ex4()
        {
            Console.WriteLine("Exercise 4: ");
            Console.WriteLine("Enter a last number of pyramid: ");
            int lastNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Pyramid: ");

            int numberInPyramid = 1;
            int i = 1;
            while (numberInPyramid <= lastNumber)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{numberInPyramid} ");
                    if (numberInPyramid == lastNumber)
                    {
                        return;
                    }
                    numberInPyramid++;
                }
                Console.WriteLine();
                i++;
            }
        }
        static void Ex5()
        {
            Console.WriteLine("Exercise 5: ");
            Console.WriteLine("Numbers to the third power");
            for (int i = 1; i <= 20; i++)
            {
                double thirdPowerOfNumber = Math.Pow(i, 3);
                Console.WriteLine($"{i} : {thirdPowerOfNumber}");
            }
        }
        static void Ex6()
        {
            Console.WriteLine("Exercise 6: ");
            for (int i = 0; i <= 20; i++)
            {
                double sum = 0;
                for (double j = 1; j <= i; j++)
                {
                    sum += 1 / j;
                    if (j == i)
                    {
                        Console.Write($"1/{j} ");
                    }
                    else
                    {
                        Console.Write($"1/{j} + ");
                    }
                }
                Console.WriteLine($"= {sum}");
            }
        }
        static void Ex7()
        {
            Console.WriteLine("Exercise 7: ");
            Console.WriteLine("Enter a length of diagonal: ");
            int diagonal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Diamond: \n");

            int var1 = diagonal / 2;
            int var2 = var1 + 1;
            int var3 = var1;
            int numberOfStars = 1;

            for (int i = 0; i < var2; i++)
            {
                for (int j = 0; j < var1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write("*");
                }
                var1--;
                numberOfStars += 2;
                Console.WriteLine();
            }

            numberOfStars -= 4;
            int numberOfSpace = 1;
            for (int i = 0; i < var3; i++)
            {
                for (int j = 0; j < numberOfSpace; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write("*");
                }
                numberOfSpace++;
                numberOfStars -= 2;
                Console.WriteLine();
            }
        }
        static void Ex8()
        {
            Console.WriteLine("Exercise 8: ");
            Console.WriteLine("Enter a string: ");
            string word = Console.ReadLine();
            string reversedWord = "";
            for (int i = word.Length-1; i >= 0; i--)
            {   
                reversedWord += word[i];
            }
            Console.WriteLine(reversedWord);
        }
        static void Ex9()
        {
            Console.WriteLine("Exercise 9: ");
            Console.WriteLine("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            string binaryNumber = "";
            while (number != 1/2)
            {
                int remainder = number % 2;
                string remainderString = remainder.ToString();
                binaryNumber = string.Concat(remainderString, binaryNumber);
                number = number / 2;
            }
            Console.WriteLine($"Binary number: {binaryNumber}");
        }
        static void Ex10()
        {
            Console.WriteLine("Exercise 10: ");
            Console.WriteLine("Enter first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            int NWD(int a, int b)
            {
                int c;
                while (b != 0)
                {
                    c = b;
                    b = a % b;
                    a = c;
                }
                return a;
            }
            int nwd = NWD(number1, number2);
            int nww = (number1 * number2) / nwd;
            Console.WriteLine($"Najmniejsza wspólna wielokrotność liczb {number1} i {number2} = {nww}");
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
        }
    }
}
