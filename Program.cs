using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace MacExercise
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            var customers = new[]
            {
                new { CustomerID = 1, FirstName = "Orlando", LastName = "Gee",
                    CompanyName = "A Bike Store" },
                new { CustomerID = 2, FirstName = "Keith", LastName = "Harris",
                    CompanyName = "Bike World" },
                new { CustomerID = 3, FirstName = "Donna", LastName = "Carreras",
                    CompanyName = "A Bike Store" },
                new { CustomerID = 4, FirstName = "Janet", LastName = "Gates",
                    CompanyName = "Fitness Hotel" },
                new { CustomerID = 5, FirstName = "Lucy", LastName = "Harrington",
                    CompanyName = "Grand Industries" },
                new { CustomerID = 6, FirstName = "David", LastName = "Liu",
                    CompanyName = "Bike World" },
                new { CustomerID = 7, FirstName = "Donald", LastName = "Blanton",
                    CompanyName = "Grand Industries" },
                new { CustomerID = 8, FirstName = "Jackie", LastName = "Blackwell",
                    CompanyName = "Fitness Hotel" },
                new { CustomerID = 9, FirstName = "Elsa", LastName = "Leavitt",
                    CompanyName = "Grand Industries" },
                new { CustomerID = 10, FirstName = "Eric", LastName = "Lang",
                    CompanyName = "Distant Inn" }
            };

            var addresses = new[]
            {
                new { CompanyName = "A Bike Store", City = "New York", Country = "United States"},
                new { CompanyName = "Bike World", City = "Chicago", Country = "United States"},
                new { CompanyName = "Fitness Hotel", City = "Ottawa", Country = "Canada"}, 
                new { CompanyName = "Grand Industries", City = "London",Country = "United Kingdom"},
            };

            var aaa = customers.Where(cus => cus.CompanyName.Equals("A Bike Store")).Select(cus => new{FirstName = cus.FirstName,LastName = cus.LastName});

            foreach (var kkk in aaa)
            {
                Console.WriteLine(kkk);
            }

        }
    }

}
