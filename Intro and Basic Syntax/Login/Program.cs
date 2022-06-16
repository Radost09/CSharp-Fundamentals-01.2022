using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";

            for(int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }
            string currentPass = Console.ReadLine();
            int invalidPass = 0;

            while(currentPass != pass)
            {
                invalidPass += 1;
                if(invalidPass == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPass = Console.ReadLine();
            }
            if(invalidPass < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
