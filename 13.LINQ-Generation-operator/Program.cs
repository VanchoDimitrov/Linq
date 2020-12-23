using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.LINQ_Generation_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<string> cities = new List<string>() { "New York", "London" };

            // 2. Linq query

            var c = cities.DefaultIfEmpty("Empty Data Set");
            var query1 = from i in c
                         select i;

            // 3. Execution
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
