using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.LINQ_Equality_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // EQUALITY OPERATOR 'SequenceEqual'
            // 1. Datasource
            List<string> cities1 = new List<string>() { "New York", "London", "Chicago", "Dublin", "Skopje" };

            List<string> cities2 = new List<string>() { "New York", "London", "Chicago", "Dublin", "Sofia" };

            // 2. Linq query. Method Query
            bool query1 = cities1.SequenceEqual(cities2); // returns false

            // 3. Execute
            Console.WriteLine($"The two collections are the same? {query1}");

            Console.ReadKey();
        }
    }
}
