using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Introduction_to_linq_queries
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<string> names = new List<string>()
            {
                "John",
                "Jason",
                "Monika",
                "David",
                "Jack",
                "Monika"
            };

            // 2. Linq query
            IEnumerable<string> query1 = from n in names
                                         where n == "Monika"
                                         select n;

            // 3. Execute Linq query or get the result
            foreach (var i in query1)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadLine();
        }
    }
}
