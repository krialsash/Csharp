using System;

namespace Homework_Functions
{
    class Program
    {
        static void Calc()
        {
            while (true)
            {
                Console.Clear();
                double a, b;

                try
                {
                    Console.WriteLine("enter first number");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("enter second number");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Don`t change string to number! ");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Enter action: +, -, *, /");
                string sign = Console.ReadLine();
                string result = "You result is ";
                double action;

                if (sign == "+")
                {
                    action = a + b;
                    Console.WriteLine(result + action);
                }
                else if (sign == "-")
                {
                    action = a - b;
                    Console.WriteLine(result + action);
                }
                else if (sign == "*")
                {
                    action = a * b;
                    Console.WriteLine(result + action);
                }
                else if (sign == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine(result + 0);
                    }
                    else
                    {
                        action = a / b;
                        Console.WriteLine(result + action);
                    }
                }
                else
                {
                    Console.WriteLine("Your action is wrong!");
                }

                Console.ReadLine();

            }
        }

        //-------------------------------------------------------
        static string Calculator(double a, double b, string sign)
        {

            /* Console.WriteLine("Enter first number");
             a  = double.Parse(Console.ReadLine());

             Console.WriteLine("Enter second number");
             b = double.Parse(Console.ReadLine());*/

            /*Console.WriteLine("Don`t change string to number! ");
            Console.ReadLine();*/

            /*Console.WriteLine("Enter action: +, -, *, /");
            string sign = Console.ReadLine();*/

            string result = "You result is ";
            double action;
            /*}

            static void Sum(double a, double b, string sign)
            {*/
            if (sign == "+")
            {
                action = a + b;
                Console.WriteLine(result + action);
            }
            else if (sign == "-")
            {
                action = a - b;
                Console.WriteLine(result + action);
            }
            else if (sign == "*")
            {
                action = a * b;
                Console.WriteLine(result + action);
            }
            else if (sign == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine(result + 0);
                }
                else
                {
                    action = a / b;
                    Console.WriteLine(result + action);
                }
            }
            else
            {
                Console.WriteLine("Your action is wrong!");
            }
            Console.ReadLine();

            return result;
        }

        static double number1()
        {
            Console.WriteLine("Enter first number");
            double result = double.Parse(Console.ReadLine());      

            return result;
        }
        static double number2()
        {
            Console.WriteLine("Enter second number");
            return double.Parse(Console.ReadLine());
        }

        static string znak()
        {
            Console.WriteLine("Enter action: +, -, *, /");
            string sign = Console.ReadLine();

            return sign;
        }

        static void Triangle()
        {

            int x = 3;
            int y = x;
        
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++, y--)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* while (true)
             {
                 Calculator(number1(), number2(), znak());
             }
 */
            Triangle();

            // Calculator(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));



        }
    }
}
