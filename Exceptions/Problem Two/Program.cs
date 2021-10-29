using System;
using System.IO;
namespace Problem_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"./lorem.txt"; //This one works under Linux. The equivalent for this path would be @".\lorem.txt" under Windows
            ReadFile(textFilePath);
        }
        static void ReadFile(string path)
        {
            try
            {
                string resultString = File.ReadAllText(path);
                System.Console.WriteLine(resultString);
            }
            catch(FileNotFoundException) {
                throw new Exception("It seems that the provided path is incorrect. Is your escaping correct?");
            }
        }
    }
}
