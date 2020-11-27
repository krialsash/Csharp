using System;
using System.Globalization;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            x = 7;
            Console.WriteLine("Hello - your number is " + (x + 5));*/

            /*string word = "Hey you! What is your name?";
            Console.WriteLine(word);
            string answer = Console.ReadLine();
            string answer1 = "My name is " + answer;
            Console.WriteLine(answer1);*/

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);*/



            /*Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);*/

            /*//Console.WriteLine("Hello World!");
            int x = 7;
            //Console.WriteLine(x);
            int y = 5;
            //Console.WriteLine(y);
            Console.WriteLine("Result is: " + x * y);*/

            /*int some;
            some = 7;
            Console.WriteLine(some);
            some = 5;
            Console.WriteLine(some);
            int some2 = 20;
            Console.WriteLine(some + some2);
            Console.WriteLine("result is:" + (some + some2));
            //Console.writeline (some + some2)*/

            //Exercise1
            /*string question1 = "What is your name?";
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
            }*/

            //Calculator-1
            /*while (true)
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
            }*/



            //Calculator-2
            /*string numA = "Enter number A:";
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
            }*/

            /*string data = Console.ReadLine();
            Console.WriteLine("Hello " + data + "!!!");*/

            /*string str1 = "5,5";
            string str2 = "7";
            double a = Convert.ToDouble(str1);
            double b = Convert.ToDouble(str2);
            Console.WriteLine(a + b);*/

            /*string str1 = "5,5";
            string str2 = "7";            
            double a = double.Parse(str1);
            double b = double.Parse(str2);
            Console.WriteLine(a + b);*/

            //srednee arifmeticheskoe
            /*double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = ((a + b) / 2);
            Console.WriteLine(result);*/

            //konverter valut
            /* int dollar = 28;
             int evro = 33;
             int btc = 477000;

             NumberFormatInfo numberFormatInfo = new NumberFormatInfo
             {
                 NumberDecimalSeparator = ".",
             };

             Console.WriteLine("Enter how many dollar do you want to buy");
             int buyDollar = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter how many euro do you want to buy");
             int buyEvro = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter how many btc do you want to buy");
             double buyBtc = double.Parse(Console.ReadLine(), numberFormatInfo);

             int resultDollar = (buyDollar * dollar);
             int resultEvro = (buyEvro * evro);
             double resultBtc = (buyBtc * btc);

             Console.WriteLine("You need to give " + resultDollar + " uah for gollars");
             Console.WriteLine("You need to give " + resultEvro + " uah for euros");
             Console.WriteLine("You need to give " + resultBtc + " uah for btc");*/

            //Проверка на четность
            /*int number = int.Parse(Console.ReadLine());
            int delete = number % 2;
            if (delete == 0)
            {
                Console.WriteLine("Четное число");
            }
            else
            {
                Console.WriteLine("Нечетное число");
            }*/

            //while
            /*int number = 0;
            int x = int.Parse(Console.ReadLine());
            while (number < x)
            {
                number++;
                Console.WriteLine(number);
            }*/

            //do while
            /*int number = 10;
            int x = int.Parse(Console.ReadLine());
            do
            {
                number++;
                Console.WriteLine(number);
            } while (number < x);*/
        }
    }
}
