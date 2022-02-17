using System;

namespace LB_8_1
{
    class Program
    {
        delegate int Numbers(int a, int b, int c);

        static void Main(string[] args)
        {
            Numbers num = Sum;
            int result = num(6, 5, 6);
            Console.WriteLine(result);
    

            Console.ReadKey();
        }

        static int Sum(int a, int b, int c) => (a + b + c) / 3;
    }
}
