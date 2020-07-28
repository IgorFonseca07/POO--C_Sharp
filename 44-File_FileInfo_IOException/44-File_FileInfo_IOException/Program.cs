using System;
using System.IO;

namespace _44_File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\44-File_FileInfo_IOException\File01.txt";
            string targetPath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\44-File_FileInfo_IOException\File02.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
