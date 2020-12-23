using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.LINQ_Set_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<int> col1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> col2 = new List<int>() { 3, 4, 5 };

            // 2. Linq query
            IEnumerable<int> query1 = col1.Union(col2);

            IEnumerable<int> query2 = col1.Except(col2);

            IEnumerable<int> query3 = col1.Concat(col2);

            IEnumerable<int> query4 = col1.Intersect(col2);

            // 3. Execute query
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
