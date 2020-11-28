using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Globalization;

namespace MyFirstApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                //Exercise1
                string question1 = "What is your name?";
                Console.WriteLine(question1);
                string answer1 = Console.ReadLine();
                Console.WriteLine("Well, hello " + answer1 + "!");
                string question2 = "Wanna buy some elephant?";
                Console.WriteLine(question2);
                string answer2 = Console.ReadLine();
                Console.WriteLine(answer2);
                if (answer2 == "no")
                {
                    Console.WriteLine("Huh, everybody says No but you have to try");
                }
                else if (answer2 == "ok")
                {
                    Console.WriteLine("Oh, that was just a joke! Relax man!)");
                }

                //Calculator-1
                while (true)
                {
                    Console.Clear();
                    double a, b;

                    try
                    {
                        string numA = "Enter number A:";
                        Console.WriteLine(numA);
                        a = double.Parse(Console.ReadLine());

                        string numB = "Enter number B:";
                        Console.WriteLine(numB);
                        b = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Don`t change string to number! ");
                        Console.ReadLine();
                        continue;
                    }

                    string action = "Write action: '+', '-', '*', '/', '%'";
                    Console.WriteLine(action);
                    string x = Console.ReadLine();
                    string result = "Your result is ";

                    if (x == "+")
                    {
                        Console.WriteLine(result + (a + b));
                    }
                    else if (x == "-")
                    {
                        Console.WriteLine(result + (a - b));
                    }
                    else if (x == "*")
                    {
                        Console.WriteLine(result + (a * b));
                    }
                    else if (x == "/")
                    {
                        if (b == 0)
                        {
                            Console.WriteLine(result + 0);
                        }
                        else
                            Console.WriteLine(result + (a / b));
                    }
                    else if (x == "%")
                    {
                        Console.WriteLine(result + (a % b));
                    }
                    else
                    {
                        Console.WriteLine("Wrong operator!");
                    }
                    Console.ReadLine();
                }

                //Calculator-2
                string numA = "Enter number A:";
                Console.WriteLine(numA);
                int a = int.Parse(Console.ReadLine());
                string numB = "Enter number B:";
                Console.WriteLine(numB);
                int b = int.Parse(Console.ReadLine());
                string action = "Write action:";
                Console.WriteLine(action);
                string x = Console.ReadLine();
                string result = "Your result is ";

                switch (x)
                {
                    case "+":
                        Console.WriteLine(result + (a + b));
                        break;
                    case "-":
                        Console.WriteLine(result + (a - b));
                        break;
                    case "*":
                        Console.WriteLine(result + (a * b));
                        break;
                    case "/":
                        Console.WriteLine(result + (a / b));
                        break;
                    default:
                        Console.WriteLine("Wrong operator!");
                        break;
                }               

                //sravnenie
                Console.WriteLine("Write number 1");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 2");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 3");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 4");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 5");
                int e = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 6");
                int f = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number 7");
                int g = int.Parse(Console.ReadLine());

                if (a > b; c, d, e, f, g)
            {
                    Console.WriteLine("Biggest number is " + a);
                }
            else if (b > c & b > d & b > e & b > f & b > g)
                {
                    Console.WriteLine("Biggest number is " + b);
                }
                else if (c > d & c > e & c > f & c > g)
                {
                    Console.WriteLine("Biggest number is " + c);
                }
                else if (d > e & d > f & d > g)
                {
                    Console.WriteLine("Biggest number is " + d);
                }
                else if (e > f & e > g)
                {
                    Console.WriteLine("Biggest number is " + e);
                }
                else if (f > g)
                {
                    Console.WriteLine("Biggest number is " + f);
                }
                else
                {
                    Console.WriteLine("Biggest number is " + g);
                }


            }
        }
    }
}
    }
}
