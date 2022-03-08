using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float number1, number2, choice;

            Console.Write("Enter a number: ");
            number1 = float.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation, typing the correspondent number: (1) sum, (2) subtraction, (3) multiplication or (4) division");
            Console.Write("Option: "); choice = int.Parse(Console.ReadLine());

            if ((choice != 1) & (choice != 2) & (choice != 3) & (choice != 4))
            {

                Console.WriteLine("Choose a valid operation");

            }
            else
            {

                if (choice == 1)
                {

                    Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);

                }
                else
                {

                    if (choice == 2)
                    {

                        Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);

                    }
                    else
                    {

                        if (choice == 3)
                        {

                            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);

                        }
                        else
                        {

                            if (choice == 4)
                            {

                                if (number2 != 0)
                                {

                                    Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);

                                }
                                else
                                {

                                    Console.WriteLine("The denominator can not be 0!");

                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
