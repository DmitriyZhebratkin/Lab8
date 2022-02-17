using System;

namespace Lab8_3
{
    public delegate int MyDelegat(int a, int b);

    class Program
    {
        static void Main()
        {
            while(true)
            { 
            Console.WriteLine("Перше число:");
            int num1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("( +,-,*,/ ) :");
            string operation = Console.ReadLine(); 

            Console.WriteLine("Друге число:");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            switch (operation)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => c + b; 
                    int del = myDelegat(num1, num2);
                    Console.WriteLine(num1 + "+" + num2 + "=" + del);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => c - b; 
                    int del1 = myDelegat1(num1, num2);
                    Console.WriteLine(num1 + "-" + num2 + "=" + del1);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => c * b; 
                    int del2 = myDelegat2(num1, num2);
                    Console.WriteLine(num1 + "*" + num2 + "=" + del2);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => c / b;
                    int del3 = myDelegat3(num1, num2);
                    Console.WriteLine(num1 + "/" + num2 + "=" + del3);
                    break;
                default:
                    Console.WriteLine("Выберите из предложанного");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
