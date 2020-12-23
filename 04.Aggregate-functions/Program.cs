using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Aggregate_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<double> sales = new List<double>() { 15590.50, 235684.50, 23567.00 };

            // 2. Linq query
            IEnumerable<double> query1 = from s in sales
                                         select s;

            var count = query1.Count();
            var max = query1.Max();
            var average = query1.Average();
            var first = query1.First();

            // 3. Execute Linq query and get the result
            Console.WriteLine($"Count: {count} Max: { max} Average: {average} First: {first}");

            Console.ReadKey();
        }
    }
}
