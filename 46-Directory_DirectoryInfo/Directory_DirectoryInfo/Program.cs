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
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
