using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    class Person
    {
        public Person(string fristName, string lastName)
        {
            FirstName = fristName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

       
    }
}
