using System;
using System.IO;
namespace Problem_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var isLinux = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux);
            var isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows);
            string textFilePath = "";
            if(isLinux)
            {
                textFilePath = @"./lorem.txt"; 
            }
            else if(isWindows)
            {
                textFilePath = @".\lorem.txt";
            }
            else
            {
                throw new Exception("Your OS is not supported.");
            }
            ReadFile(textFilePath);
        }
        static void ReadFile(string path)
        {

            string resultString = File.ReadAllText(path);
            System.Console.WriteLine(resultString);
            

        }
    }
}
