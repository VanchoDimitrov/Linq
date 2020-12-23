using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Caching_and_immediate_execution_of_a_query
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            List<double> sales = new List<double>() { 15590.50, 235684.50, 23567.00 };

            // 2. Linq query
            List<double> query1 = (from s in sales
                                   select s).ToList();

            double[] query2 = (from s in sales select s).ToArray();

            // 3. Execute Linq query and get the result
            foreach (var i in query2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
