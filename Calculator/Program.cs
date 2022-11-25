using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1, number2;
            int operation = 1;

            while (operation > 0 && operation < 5)
            {
                Console.Write("Enter a number: ");
                number1 = float.Parse(Console.ReadLine());

                Console.Write("Enter another number: ");
                number2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operation, typing the correspondent number: " +
                    "\n(1) sum \n(2) subtraction \n(3) multiplication \n(4) division \n(0) exit"
                );
                Console.Write("Option: ");
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Result: " + Sum(number1, number2));
                        break;

                    case 2:
                        Console.WriteLine("Result: " + Subtraction(number1, number2));
                        break;

                    case 3:
                        Console.WriteLine("Result: " + Multiplication(number1, number2));
                        break;

                    case 4:
                        Console.WriteLine(
                            "Result: " +
                            (number2 == 0 ? Division(number1, number2) : "Can not divide by 0")
                        );
                        break;

                    default:
                        break;
                }

                Console.WriteLine("\nPress Any Key To Continue");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
        static float Sum(float number1, float number2) =>
            number1 + number2;

        static float Subtraction(float number1, float number2) =>
            number1 - number2;

        static float Multiplication(float number1, float number2) =>
            number1 * number2;

        static float Division(float number1, float number2) =>
            number1 / number2;
    }
}