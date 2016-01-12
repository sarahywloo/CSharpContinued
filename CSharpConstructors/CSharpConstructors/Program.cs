using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors {
    class Program {
        static void Main(string[] args) {

            //Product with constructor
            var snack = new Product("Goldfish Snack", 3.45m, 5, "Xplosive pizza flavored");
            Console.WriteLine("{0} Price: {1:c} Units In Stock: {2} Description: {3} ", snack.Name, snack.Price, snack.UnitsInStock, snack.Description);
            Debug.Assert(snack.Name == "Goldfish Snack", "Product: Goldfish Snack");
            var drink = new Product("Sprite", 1.05m, 10);
            Console.WriteLine("{0} Price: {1:c} Units In Stock: {2}", drink.Name, drink.Price, drink.UnitsInStock);

            //Customer with constuctor
            var sarah = new Customer("Sarah", "Kim", 24, "sarahkim@yahoo.com");
            Console.WriteLine("Name: {0} {1} Age: {2} Email Address: {3}", sarah.FirstName, sarah.LastName, sarah.Age, sarah.Email);

            Customer sally = new Customer() {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                Email = "sallywilliams@gmail.com",
                BillingAddress = new Address() {
                    Street = "12345 Somewhere",
                    City = "Pearland",
                    State = "Texas",
                    Zipcode = "77123"
                },
                ShippingAddress = new Address() {
                    Street = "12345 Somewhere Else",
                    City = "Houston",
                    State = "Texas",
                    Zipcode = "77000"
                }
            };

            Address mikeAddress = new Address() {
                Street = "55555 This Place",
                City = "Houston",
                State = "Texas",
                Zipcode = "70707"
            };

            Customer mike = new Customer() {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 45,
                Email = "mikeharrison@gmail.com",
                BillingAddress = mikeAddress,
                ShippingAddress = mikeAddress
            };

            //Bank Account Complex Classes

            Customer alice = new Customer() {
                Check = new BankAccount() {
                    ID = "Alice1",
                    Type = "Checking Account",
                    Amount = 100m,
                    IsOpen = true
                },

                Save = new BankAccount() {
                    ID = "Alice2",
                    Type = "Savings Account",
                    Amount = 0m,
                    IsOpen = false
                }
            };

            Customer sarahKim = new Customer() {
                Save = new BankAccount() {
                    ID = "Sarah1",
                    Type = "Savings Account",
                    Amount = 4539.88m,
                    IsOpen = true
                }
            };

            

            alice.Transfer(sarahKim.Save, alice.Check, 100m);

            Console.WriteLine("Alice's Current Balance: {0:c}", alice.Check.Amount);
            Console.WriteLine("Sarah's Current Balance: {0:c}", sarahKim.Save.Amount);

            Console.ReadLine();
        }
    }
}
