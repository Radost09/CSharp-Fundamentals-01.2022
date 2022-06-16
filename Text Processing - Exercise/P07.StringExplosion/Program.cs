using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            StringBuilder outputStr = new StringBuilder();

            int bombPower = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currentCh = inputStr[i];

                if (currentCh == '>')
                {
                    int currentBombPower = GetIntValueOfCharacter(inputStr[i + 1]);

                    outputStr.Append(currentCh);
                    bombPower += currentBombPower;
                }
                else
                {
                    if(bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputStr.Append(currentCh);
                    }
                }
            }
            Console.WriteLine(outputStr.ToString());
        }

        static int GetIntValueOfCharacter(char ch)
        {
            return (int)ch - 48;
        }
    }
}
