using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects {
    class Program {
        static void Main(string[] args) {
            var milk = new Product() {
                Name = "1% Milk",
                Price = 3.00m,
                Description = "Milk!",
                UnitsInStock = 5
            };

            //milk.Name = "1% Milk";
            //milk.Price = 3.00m;
            //milk.Description = "Milk!";
            //milk.UnitsInStock = 5;

            Console.WriteLine("Name: {0}\n{0}'s Price without tax: {1:c}\n{0}'s Price with tax: {2:c}",         
                milk.Name, 
                milk.Price, 
                milk.TotalPrice);

            var sally = new Customer() {
                FirstName = "Sally",
                LastName = "Williams",
                //Age = 23,
                BirthDate = new DateTime (1993, 1, 1)
            };

            var mike = new Customer() {
                FirstName = "Mike",
                LastName = "Harrison",
                //Age = 10 ,
                BirthDate = new DateTime (2006, 1, 1)
            };

            Debug.Assert(sally.Age == 23, "Sally is supposed to be 23.");
            Debug.Assert(mike.Age == 10, "Mike is supposed to be 10.");

            Debug.Assert(sally.Age != 0, "Age cannot be zero!");
            Debug.Assert(mike.Age != 0, "Age cannot be zero!");

            Debug.Assert(sally.BirthDate < DateTime.Now, "Your birthdate cannot be in the future!!!");
            Debug.Assert(mike.BirthDate < DateTime.Now, "Your birthdate cannot be in the future!!!");

            Console.ReadLine();
        }
    }
}
