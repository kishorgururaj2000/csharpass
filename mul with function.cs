﻿namespace ConsoleApp1
{
    class MulWithFunction
    {
        public static int Mul(int num1, int num2, int num3)
        {
            int result;
            result = num1 * num2 * num3;
            return result;
        }
        public static void Main()
        {
            int num1, num2, num3;
        
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine($"The result of the multiplication is {result}");

        }

    }
}
