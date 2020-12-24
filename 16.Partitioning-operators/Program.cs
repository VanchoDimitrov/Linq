using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Partitioning_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            p.Skip();
            //p.SkipWhile();
            //p.Take();
            //p.TakeWhile();
        }


        public void Skip()
        {
            // 1. Datasource
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // 2. Linq query
            IEnumerable<int> query1 = numbers.Skip(3);
            // 3. Execute query
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }

        public void SkipWhile()
        {
            // 1. Datasource
            List<string> numbers = new List<string>() { "John", "Jason", "Jacky", "Monica" };

            // 2. Linq query
            IEnumerable<string> query1 = numbers.SkipWhile(x => x.Length <= 5);
            // 3. Execute query
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }

        public void Take()
        {
            // 1. Datasource
            List<string> names = new List<string>() { "John", "Jason", "Jacky", "Monica" };

            // 2. Linq query
            IEnumerable<string> query1 = names.Take(3);
            // 3. Execute query
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }

        public void TakeWhile()
        {
            // 1. Datasource
            List<string> names = new List<string>() { "John", "Jason", "Jacky", "Monica" };

            // 2. Linq query
            IEnumerable<string> query1 = names.TakeWhile(x => x.Length <= 5);
            // 3. Execute query
            foreach (var i in query1)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
