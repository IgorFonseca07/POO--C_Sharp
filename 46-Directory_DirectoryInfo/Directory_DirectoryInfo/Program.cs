using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\46-Directory_DirectoryInfo\MyFolders";

            try
            {
                //Pode-se usar o "var" no lugar do IEnumerable<> que o C# detecta que é um IEnumerable
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string x in folders)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string x in files)
                {
                    Console.WriteLine(x);
                }

                Directory.CreateDirectory(path + @"\NewFolder"); //Ou pode se usar "//NewFolder" ou invés de usar o @ antes!
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
