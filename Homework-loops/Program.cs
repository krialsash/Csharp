using System;

namespace Homework_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //+
            //++
            //+++
            /*int a = 3;
            int b = 0;

            while (b < a)
            {
                int c = 0;

                while (c <= b)
                {
                    Console.Write("+");
                    c++;
                }
                Console.WriteLine();
                b++;
            }*/

            //+++
            //++
            //+
            /*int a = 3;
            int b = 0;

            while (b <= a)
            {
                int c = 3;

                while (c > b)
                {
                    Console.Write("+");
                    c--;
                }
                Console.WriteLine();
                b++;
            }*/

            //+++*
            //++**
            //+***
            /* int a = 3;
             int b = 0;

             while (b <= a)
             {
                 int c = 3;
                 while (c > b)
                 {
                     Console.Write("-");
                     c--;
                 }

                 int d = 0;
                 while (d < b)
                 {
                     Console.Write("*");
                     d++;
                 }
                 Console.WriteLine();
                 b++;
             }*/

            //+***
            //++**
            //+++*
            /*int a = 2;
            int b = 0;

            while (b <= a)
            {
                int c = 0;
                while (c <= b)
                {
                    Console.Write("-");
                    c++;
                }

                int d = 3;
                while (d > b)
                {
                    Console.Write("*");
                    d--;
                }
                Console.WriteLine();
                b++;
            }*/

            //+++*
            //++***
            //+*****
            /*int a = 2;
            int b = 0;

            while (b <= a)
            {
                int c = 3;
                while (c > b)
                {
                    Console.Write("-");
                    c--;
                }

                int d = 0;
                while (d <= b * 2)
                {
                    Console.Write("*");
                    d++;

                }
                Console.WriteLine();
                b++;
            }*/

            //+++*
            //++***
            //+*****
            //++***
            //+++*
            /*int a = 1;
            int b = 0;

            while (b <= a)
            {
                int c = 2;
                while (c > b)
                {
                    Console.Write("-");
                    c--;
                }

                int d = 0;
                while (d <= b * 2)
                {
                    Console.Write("*");
                    d++;

                }
                Console.WriteLine();
                b++;
            }
            //++***
            //+++*
            //+
            //++
            //+++
            a = 3;
            b = 1;

            while (b < a)
            {
                int c = 0;

                while (c <= b)
                {
                    Console.Write("-");
                    c++;
                }
                Console.WriteLine();
                b++;
            }*/

            //table of multipli
            Console.WriteLine("Table of multipli");
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine("\t");
                int y = 1;
                int z = 0;
                while (y <= 10)
                {
                    z = x * y;
                    Console.Write(x + " * " + y + " = " + z + "\t");
                    //Console.WriteLine(y);
                    y++;
                }
                x++;
            }
        }
    }
}
