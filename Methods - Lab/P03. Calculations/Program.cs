using System;

namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());  

            switch(command)
            {
                case "add": Add(firstNumber, secondNumber); 
                    break;
                case "multiply": Multiply(firstNumber, secondNumber);
                    break;
                case "subtract": Substract(firstNumber, secondNumber);
                    break;
                case "divide": Divide(firstNumber, secondNumber);
                    break;

            }
        }

        private static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Substract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
