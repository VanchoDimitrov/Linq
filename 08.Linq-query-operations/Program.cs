using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Linq_query_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Data Source

            #region commented
            var persons = new List<Person> {
                new Person{employeeID=1, name="John", lastName="Doe", city = "Munich"},
                new Person{employeeID=2, name="Jason", lastName= "McOrnik", employeeType ="Manager", city = "Munich"},
                new Person{employeeID=3, name="Monica", lastName= "Carson", employeeType ="CEO", city = "London"},
                new Person{employeeID=4, name="Mike", lastName= "Spenser", city = "New York"},
                new Person{employeeID=5, name="Jacky", lastName= "Mirson", employeeType ="Manager"},
                new Person{employeeID=6, name="Jack", lastName= "Jacobson", city = "New Orleans" },
                new Person{employeeID=7, name="Elena", lastName= "Morrision", city = "New Orleans" },
                new Person{employeeID=8, name="Ema", lastName= "Truman", city = "New Orleans" },
                new Person{employeeID=8, name="Monica", lastName= "Truman", city = "New Orleans" }
            };

            var orders = new List<Order>
            {
                new Order {
                    orderNumber= 101,
                    total = 1256.50,
                    person = new Person{
                        employeeID = 1
                    }
                },
                new Order {
                    orderNumber= 102,
                    total = 2450.50,
                    person = new Person{
                        employeeID = 1
                    }
                },
                new Order {
                    orderNumber= 103,
                    total = 345.50,
                    person = new Person{
                        employeeID = 2
                    }
                },
                new Order {
                    orderNumber= 104,
                    total = 1000.00,
                    person = new Person{
                        employeeID = 3
                    }
                }
            };
            #endregion

            string[] coordinates = { "123124 2134253", "23423423 34535234", "234234324 123123213", "353487876 435345767" };

            // 2. Linq query

            // Filtering
            var query1 = from p in persons
                         where p.name == "Monica"
                         select p;

            // operator &&
            var query2 = from p in persons
                         where p.name == "Monica" && p.employeeType == "CEO"
                         select p;

            // || or
            var query3 = from p in persons
                         where p.name == "Monica" || p.employeeType == "CEO"
                         select p;

            // OrderBy
            var query4 = from p in persons
                         orderby p.name
                         select p;

            // Group By
            var query5 = from p in persons
                         group p by p.employeeType into personGroup
                         where personGroup.Count() > 0
                         orderby personGroup.Key
                         select personGroup;

            // join
            var query6 = from o in orders
                         join p in persons on o.person.employeeID equals p.employeeID
                         select new
                         {
                             Name = p.name,
                             City = p.city,
                             OrderNumber = o.orderNumber,
                             OrderTotal = o.total
                         };

            // 3. Execute Linq query and get the result
            ////query1 - query4
            //foreach (Person i in query6)
            //    Console.WriteLine(i.employeeID + " " + i.name + " " + i.lastName + " EMployee Type: " + i.employeeType);


            ////query5
            //foreach (var pg in query5)
            //{
            //    Console.WriteLine(pg.Key);
            //    foreach (Person p in pg)
            //    {
            //        Console.WriteLine(p.employeeID + " " + p.name + " " + p.lastName + " EMployee Type: " + p.employeeType);
            //    }
            //}

            // query6
            foreach (var p in query6)
                Console.WriteLine(p.Name + " " + p.City + " Order#: " + p.OrderNumber + " Total: " + p.OrderTotal);





            // let clause
            IEnumerable<string> query7 = from c in coordinates
                                         let coord = c.Split(' ')[0]
                                         select coord;


            // Subqueries
            var query8 = from o in orders
                         join p in persons on o.person.employeeID equals p.employeeID
                         where p.employeeID == 1
                         select new
                         {
                             Name = p.name,
                             City = p.city,
                             OrderNumber = o.orderNumber,
                             OrderTotal = o.total
                         };


            // Order total by order number
            var query9 = from ord in orders
                         join osubquery in (from o in orders
                                       where o.orderNumber == 102
                                       select o)
                            on ord.orderNumber equals osubquery.orderNumber
                         select new {
                             ord.orderNumber,
                             ord.total
                         };

            //Combining Linq query with Linq method syntax
            var query10 = from p in persons.Where(x => x.name == "Monica")
                          select new
                          {
                              p.employeeID,
                              p.name,
                              p.lastName
                          };

            //foreach (var i in query7)
            //    Console.WriteLine(i);


            // 3. Linq query execution
            foreach (var i in query8)
                Console.WriteLine(i.Name + ", " + i.City + ", " + i.OrderNumber + ", " + i.OrderTotal);


            

            


            Console.ReadLine();
        }

        public class Person
        {
            public int employeeID { get; set; }
            public string name { get; set; }
            public string lastName { get; set; }
            public string employeeType { get; set; }
            public string city { get; set; }

            public Person()
            {
                this.employeeType = "Employee";
            }
        }

        public class Order
        {
            public int orderNumber { get; set; }

            public double total { get; set; }

            public Person person { get; set; }
        }
    }
}