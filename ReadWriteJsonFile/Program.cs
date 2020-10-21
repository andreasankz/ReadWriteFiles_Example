using SharedLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //JsonService.WriteToFile(@"d:\files\persons.json", new Person("Andreas","Saarenpää",30,"Lindesberg"));
            
            JsonService.WriteToFileCorrect(@"d:\files\persons.json", new Person("Andreas", "Saarenpää", 30, "Lindesberg"));
            JsonService.ReadFromFile(@"d:\files\persons.json");
        }
    }
}
