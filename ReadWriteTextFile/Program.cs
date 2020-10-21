using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        
        static void Main(string[] args)
        {


            WriteToFile("textfile.txt", "My name is Andreas Saarenpää and i am 30 years old and lives in Örebro. ");
            WriteToFile("textfile.txt", "My brother name is old");
            ReadFromFile("textfile.txt");
        }

        private static void WriteToFile(string filename, string content) // Kan lägga lver i Classlibrary
        {
            

            File.AppendAllText(@$"D:\files\{filename}", content);

            //File.WriteAllLines(@$"D:\files\{filename}",lines);

        }
        private static void ReadFromFile(string filename)             // kan lägga i över i classlibrary
        { 
            var content = File.ReadAllText(@$"D:\files\{filename}");
            Console.WriteLine(content);

        }



    }
}
