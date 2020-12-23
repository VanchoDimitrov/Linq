using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Other_Linq_query_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define Data Source
            Person p = new Person();
            var persons = p.Persons(p.persons);

            // Select query operator
            var query1 = from i in persons
                         select new
                         {
                             ID = i.PersonID,
                             Name = i.Name
                         };

            // same as above but method syntax
            var method1 = persons.Select(s => new { ID = s.PersonID, Name = s.Name });

            foreach (var i in query1)
            {
                Console.WriteLine(i.ID + ", " + i.Name);
            }

            // Quantifier operators All, Any, Contains

            // All - quantifier operator in a method syntax = True/False
            bool method2 = persons.All(s => s.Name == "John"); // It checks if all names in the collection are with name John
            Console.WriteLine(method2); // result is true or false based on the condition

            // Any - checks if any of the condition is satisfied
            bool method3 = persons.Any(s => s.Name == "John");
            Console.WriteLine(method3); //returns true or false

            // Contains
            Person p1 = new Person() { PersonID = 4, Name = "Jesica" };
            bool method4 = persons.Contains(p1); // it will check if the collections contains Jesica
            Console.WriteLine(" YES, JESSIE BABY S" + method4);

            // Contains
            int[] numbers = new int[] { 111, 1, 2, 3, 4 };

            bool method5 = numbers.Contains(2);
            Console.WriteLine(method5);



            // ElementAt() and ElementAtOrDefault()
            // ElementAt() - prints an element from a collection based on index position. It throws an exception if not found

            //ElementAtOrDefault() - prints an element from a collection based on index position. It does not throw an exception if not found
            // but displays a default value
            Console.WriteLine(numbers.ElementAt(1)); //1
            Console.WriteLine(numbers.ElementAtOrDefault(6)); // element at index 6 does not exists and it will print 0 at index 0


            // First() and FirstOrDefault()
            // First() - prints the first element of collection. if value not found throws an exception
            Console.WriteLine(numbers.First());

            // FirstOrDefault() prints first element of collection, it does not throw an exception but prints out default value if not found
            Console.WriteLine(numbers.FirstOrDefault());


            // Last() and LastOrDefault()
            // Last() - prints the last element of collection. if element is not found throws an exception
            Console.WriteLine(numbers.Last());

            // LastOrDefault() prints last element of collection, it does not throw an exception but prints out default value if not found
            Console.WriteLine(numbers.LastOrDefault());

            // Single() and SingleOrDefault()
            // Single() - prints only one element provided that condition is met if not throws an exception
            Console.WriteLine(numbers.Single(i => i < 2));

            // SingleOrDefault() - prints only one element provided condition is met or prints deffault value and does not throw an exception
            Console.WriteLine(numbers.SingleOrDefault(i => i < 1)); // prints default 0 value. condition not met






            // Equality Operator - SequenceEqual() returns True/False
            int[] numbers1 = { 1, 2 };
            int[] numbers2 = { 1, 2 };

            var result = numbers1.SequenceEqual(numbers2); // it checks if both arrays are the same
            Console.WriteLine(result);



            // Generation operator - DefaultIfEmpty()
            // DefaultIfEmpty() - if empty collection is returned then return default value for the collection
            List<string> cities = new List<string>(); ;// { "New York", "London" };

            var newCollectionCities1 = cities.DefaultIfEmpty();
            var newCollectionCities2 = cities.DefaultIfEmpty("Empty data set");

            Console.WriteLine("newCollectionCities1 {0} ", newCollectionCities1.ElementAt(0)); // prints nothing
            Console.WriteLine("newCollectionCities2 {0} ", newCollectionCities2.ElementAt(0)); // prints 'Empty data set'

            Console.WriteLine();




            // Filtering operator - Distinct - returns unique collection and not doubles.

            int[] distunctNumbers = { 1, 2, 3, 4, 2, 3, 4, 5, 6, 7, 3, 2 };

            foreach (var i in distunctNumbers.Distinct()) // double elements are omited
                Console.WriteLine(i);

            string[] distinctNames = { "John", "Jacky", "John", "Monika", "Jason" };

            foreach (var i in distinctNames.Distinct())
                Console.WriteLine(i);


            // Set operators
            // Concatenation of two collections
            List<string> name = new List<string> { "John" };
            List<string> lastName = new List<string> { "Doe" };

            IEnumerable<string> nameLastName = name.Concat(lastName);
            foreach (var i in nameLastName)
                Console.Write(i + " ");

            Console.WriteLine();



            // Except - returns elements which are not found in the second collection
            string[] collection1 = { "one", "two", "three" };
            string[] collection2 = { "two", "three", "four" };

            var resultExcept = collection1.Except(collection2);
            foreach (var i in resultExcept)
                Console.WriteLine(i); // prints only 'one' as it is not contained in collection2

            // Intersect - returns collection of elements which exists in both collections
            int[] intersectCollection1 = { 1, 2, 3, 4, 5, 6 };
            int[] intersectCollection2 = { 3, 4, 5 };

            var resultIntersect = intersectCollection1.Intersect(intersectCollection2);
            foreach (var i in resultIntersect)
                Console.WriteLine(i); // 3, 4, 5

            // Union - returns distinct elements from two collections.
            int[] unionCollection1 = { 1, 2, 3, 4, 5 };
            int[] unionCollection2 = { 3, 4, 5 };

            var unionResult = unionCollection1.Union(unionCollection2);
            foreach (var i in unionResult)
                Console.WriteLine(i);





            // Partitioning Operators: Skip() and SkipWhile()
            List<int> skipCollection1 = new List<int>() { 1, 2, 3, 4, 5 };

            var resultSkip = skipCollection1.Skip(3);
            foreach (var i in resultSkip)
                Console.WriteLine(i);

            // SkipWhile
            List<string> skipWhileCollection1 = new List<string>() { "John", "Jason", "Jacky", "Monika" };

            var resultSkipWhile = skipWhileCollection1.SkipWhile(x => x.Length < 5); // equals or more than 5 letters
            foreach (string i in resultSkipWhile)
                Console.WriteLine("Result {0}", i);


            // Take() and TakeWhile()
            List<int> takeCollection1 = new List<int>() { 1, 2, 3, 4, 5 };

            var resultTake = takeCollection1.Take(3);
            foreach (var i in resultTake)
                Console.WriteLine("Take: {0}", i); // 3 it takes the first 3 elements of the collection

            // TakeWhile
            List<string> takeWhileCollection1 = new List<string>() { "John", "Jason", "Jacky", "Monika" };

            var resultTakeWhile = takeWhileCollection1.TakeWhile(x => x.Length < 5); // equals or more than 5 letters
            foreach (string i in resultTakeWhile)
                Console.WriteLine("TakeWhile {0}", i); // John meets the condition because the length is < 5 letters
        }

        class Person
        {
            public int PersonID { get; set; }
            public string Name { get; set; }
            public string yearOfEntry { get; set; }

            public List<Person> persons { get; set; } = new List<Person>();

            public List<Person> Persons(List<Person> persons)
            {
                persons = new List<Person>()
                {
                    new Person { PersonID = 1, Name = "John", yearOfEntry = "2020"},
                    new Person { PersonID=2, Name = "Jacky", yearOfEntry = "2019" },
                    new Person { PersonID=3, Name = "Monika", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Jesica", yearOfEntry = "2019" },
                    new Person { PersonID=3, Name = "Jackline", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Alexander", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Britney", yearOfEntry = "2019" }
                };

                return persons;
            }
        }
    }
}
