using SharedLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            


            string content = "Andreas;Saarenpää;30;Lindesberg;Mattias;Johannson;40;Örebro";
            CsvService.WriteToFile(@"D:\files\persons.csv", content);
            var persons = CsvService.ReadFromFile(@"D:\files\persons.csv");


            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old and lives in {person.City}");
            }
        }



    }
}
