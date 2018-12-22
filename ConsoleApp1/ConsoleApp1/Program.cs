using System;
using System.Collections.Generic;
using System.Linq; //must add if we use lambda expresion
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My awesome students";
            int wNo = Extension.WordCount(myString);
            int wNoFromExtension = myString.WordCountExtension();

            var now = DateTime.Now;

            Console.WriteLine(now.RoundToHalfHour());


            List<Person> persons = new List<Person>();

            persons.Add(new Person()

            {
                City = "Suceava",
                FirstName = "Marian",
                LastName = "Runcan",
                Country = "Romania"



            });

            persons.Add(new Person()

            {
                City = "Bihor",
                FirstName = "Andrei",
                LastName = "Mairean",
                Country = "Bulgaria"



            });

            persons.Add(new Person()

            {
                City = "Cluj",
                FirstName = "Ionut",
                LastName = "Andrei",
                Country = "Belgia"



            });

            var student = new //Anonymous types
            {
                Name = "student 1",
                Course = ".Net"
            };
            Console.WriteLine(student.Course + student.Name);


            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1); //Must add LINQ(language integrated query)


            var personInity = persons.Where(person => person.City == "Iasi")
                .OrderBy(x=>x.FirstName)
                .OrderByDescending(x=>x.Country.WordCountExtension()).ToList();

            var personInCityClass = new List<Person>();
            foreach (var person in persons)
            {
                if(person.City == "Iasi")
                {
                    personInCityClass.Add(person);
                }

            }

             

        } 

    }
}
