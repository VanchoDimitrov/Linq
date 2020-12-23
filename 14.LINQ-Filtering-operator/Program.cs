using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LINQ_Filtering_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<string> names = new List<string>() {
            "John",
            "Jacky",
            "Monica",
            "Jason",
            "John",
            "Monica",
            "Monika",
            "Jon",
            "Bdandon",
            "Chris",
            "Monicanson"
            };

            // 2. Linq query
            var query1 = (from n in names
                          where n.Contains("Mon")
                          select n).Distinct();

            // 2.1 Method query
            var query2 = names.Where(x => x.Contains("Mon")).Distinct();

            // 3. Execution
            foreach (var i in query2)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
