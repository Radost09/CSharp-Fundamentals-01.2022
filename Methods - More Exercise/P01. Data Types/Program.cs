using System;

namespace P01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();

            ReadVariable(input, secondInput);
        }
        static void ReadVariable(string input, string secondInput)
        {
            int firstNum = 0;
            double secondNum = 0;

            if (input == "int")
            {
                int.TryParse(secondInput, out firstNum);
                Console.WriteLine($"{firstNum * 2}");
            }
            else if(input == "real")
            {
                double.TryParse(secondInput, out secondNum);
                Console.WriteLine($"{secondNum * 1.5 :f2}");
            }
            else
            {
                Console.WriteLine($"${secondInput}$");
            }
        }
    }
}
