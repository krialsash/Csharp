using System;

namespace sravnenie_2h_chisel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 45;
            int c = 37;
            int max = -1;
            max = a;

            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine(max);

        }
    }
}
