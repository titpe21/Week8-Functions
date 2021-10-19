using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '-', '*' või '/'");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumbers(firstNumber, secondNumber);
                    break;
                case '/':
                    DivideTwoNumbers(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
            }


        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        
        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
    }
}
