using System;
using System.Globalization;
using System.IO;

namespace _48_Exerc18
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string sourcePath = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\48-Exerc18\CSV";

                Directory.CreateDirectory(sourcePath + @"\Out");

                string targetPath = sourcePath + @"\Out";

                string[] lines = File.ReadAllLines(sourcePath + @"\Products.csv");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();

                foreach (string line in lines)
                {
                    string[] columns = line.Split(';');

                    double unitPrice = double.Parse(columns[1], CultureInfo.InvariantCulture);
                    double quantity = double.Parse(columns[2], CultureInfo.InvariantCulture);

                    using (StreamWriter sw = File.AppendText(targetPath + @"\Summary.csv"))
                    {
                        sw.WriteLine(columns[0] + ";" + new Methods().TotalPrice(unitPrice, quantity).ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

                lines = File.ReadAllLines(targetPath + @"\Summary.csv");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

        }
    }
}
