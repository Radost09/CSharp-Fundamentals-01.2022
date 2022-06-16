using System;

namespace P11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));
        }
        static double Calculate(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;
            switch(@operator)
            {
                case "/": result = firstNumber / secondNumber;
                    break;
                case "*": result = firstNumber * secondNumber;
                    break;
                case "+": result = firstNumber + secondNumber;
                    break;
                case "-": result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}
