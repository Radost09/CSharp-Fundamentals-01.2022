using System;

namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int startIndexOfFile = path.LastIndexOf('\\') + 1;
            string file = path.Substring(startIndexOfFile);
            int startIndexOfExtention = file.LastIndexOf('.') + 1;
            string nameOfFile = file.Substring(0, startIndexOfExtention - 1);
            string extentionOfFile = file.Substring(startIndexOfExtention);

            Console.WriteLine($"File name: {nameOfFile}");
            Console.WriteLine($"File extension: {extentionOfFile}");
        }
    }
}
