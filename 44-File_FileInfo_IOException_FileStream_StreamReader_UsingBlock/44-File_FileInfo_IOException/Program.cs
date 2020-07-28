using System;
using System.IO;

namespace _44_File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\44-File_FileInfo_IOException_FileStream_StreamReader_UsingBlock\File01.txt";
            string targetPath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\44-File_FileInfo_IOException_FileStream_StreamReader_UsingBlock\File02.txt";

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
            Console.WriteLine();



            // FileStream and StreamReader


            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(sourcePath, FileMode.Open);
                // sr = new StreamReader(fs);
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //  if (fs != null) fs.Close();
            }
            Console.WriteLine();

            

            // Using Block

            try
            {
                // using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                // {
                    // using (StreamReader sr2 = new StreamReader(fs))
                    using (StreamReader sr2 = File.OpenText(sourcePath))
                    {
                        while (!sr2.EndOfStream)
                        {
                            string line = sr2.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                // }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
