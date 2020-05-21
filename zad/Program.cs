using System;
using System.Drawing;

namespace zad
{
    class Program
    {
        static void Main(string[] args)
        {

            person[] persons =
            {
                new person("John",25,gender.boy),
                new person("Jessie",30,gender.girl),
                new person("Johanna",28,gender.girl),


            };
            Console.WriteLine("Dane");
            persons.DisplayArray();
            Console.WriteLine("Sortowanie");
            Array.Sort(persons, new PersonageComparer());
            persons.DisplayArray();
            Console.ReadLine();

            Console.WriteLine("Filtracja");
            
           
            

        }
    }
}
