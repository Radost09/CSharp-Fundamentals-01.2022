using System;
using System.Linq;
using System.Text;

namespace P05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherChars = new StringBuilder();

            string text = Console.ReadLine();

            //char[] allDigits = text.Where(item => char.IsDigit(item)).ToArray();
            //char[] allLetters = text.Where(item => char.IsLetter(item)).ToArray();
            //char[] allOtherChars = text.Where(item => !char.IsLetterOrDigit(item)).ToArray();

            //Console.WriteLine(new string(allDigits));
            //Console.WriteLine(new string(allLetters));
            //Console.WriteLine(new string(allOtherChars));

            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    otherChars.Append(item);
                }
            }
            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(otherChars.ToString());
        }
    }
}
