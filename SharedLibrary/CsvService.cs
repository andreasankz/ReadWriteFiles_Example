﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharedLibrary
{
    public class CsvService
    {
        public static void WriteToFile(string filepath, string content)
        {
            var line = new List<string>()
            {
                content
            };
            File.AppendAllLines(filepath, line);


        }
        public static IEnumerable<Person> ReadFromFile(string filepath, char delimiter = ';') // IEnumerable eller List
        {
            var lines = File.ReadAllLines(filepath).ToList();
            var persons = new List<Person>();

            foreach (var line in lines)
            {
                var data = line.Split(delimiter);

                persons.Add(new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]));


            }

            return persons;

        }
    }
}
