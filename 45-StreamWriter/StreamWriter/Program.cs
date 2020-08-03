using System;
using System.IO;

namespace StreamWriter_
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\45-StreamWriter\File01.txt";
            string targetPath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\45-StreamWriter\File02.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string x in lines)
                {
                    Console.WriteLine(x);
                }

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string x in lines)
                    {
                        sw.WriteLine(x.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
