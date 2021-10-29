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
            
            try{
                string resultString = File.ReadAllText(path);
                System.Console.WriteLine(resultString);

            }
            catch(UnauthorizedAccessException)
            {
                throw new Exception("It seems that you do not have access to this file.");
            }
            catch(Exception)
            {
                throw new Exception("It seems that the path provided leads to nowhere.");
            }
            

        }
    }
}
