using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compiler_handling_of_the_generic_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<Person> persons = new List<Person>()
            {
                new Person{ name="John", lastName="Doe"},
                new Person{ name="Jason", lastName="Davidson"}
            };

            // 2. Linq query
            var query1 = from p in persons
                                         where p.name == "Jason"
                                         select p;

            // 3. Execute Linq query and get the result
            foreach (Person p in query1)
                Console.WriteLine(p.name + " " + p.lastName);

            Console.ReadKey();
        }

        class Person
        {
            public string name { get; set; }
            public string lastName { get; set; }
        }
    }
}
