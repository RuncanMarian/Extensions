using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DateTime BirthDate { get => DateTime.Now; } //metoda Lambda mai simpla

        public DateTime BirthDate2
        {
            get { return DateTime.Now; }
        }


    }
}
