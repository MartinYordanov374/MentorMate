using System;
using System.IO;

namespace FoldersTree
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"./ParentFolder"); // Apparently that way works under linux, for windows it the path would be @".\ParentFolder"
            getDirectories(directory, 0);
        }
        static void getDirectories(DirectoryInfo directory, int depth)
        {
            if(depth >= 20)
            {
                return;
            }
            if(directory.Exists)
            {

               string dirName = directory.Name;

               int childrenDirectoriesAmount = directory.GetDirectories().Length;
               int minimalDirectoriesAmount = 1;

               Console.WriteLine(
                   childrenDirectoriesAmount >= minimalDirectoriesAmount 
                   ? "[+] " + new string('-', depth + 1) + " " + dirName 
                   : "[=] " + new string('-', depth + 1) + " " + dirName
                );

               DirectoryInfo[] subDirectories = directory.GetDirectories();

               foreach(DirectoryInfo subDirectory in subDirectories)
               {
                   getDirectories(subDirectory, depth + 1);
               }
            }
            else
            {
                Console.WriteLine("Folder does not exist");
            }
        }
    }
}
