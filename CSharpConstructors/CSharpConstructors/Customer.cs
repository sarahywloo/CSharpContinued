using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors {
    class Customer {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        //Customer Constructor that takes no arguements
        public Customer () { }

        public Customer(string firstname, string lastname, int age, string email) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
        }

        public Customer(string firstname, string lastname, int age, string email, string contactnumber) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
            ContactNumber = contactnumber;
        }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public Customer(string firstname, string lastname, int age, string email, Address billingaddress, Address shippingaddress) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Email = email;
            BillingAddress = billingaddress;
            ShippingAddress = shippingaddress;
        }

        public BankAccount Check { get; set; }
        public BankAccount Save { get; set; }

        public void Transfer(BankAccount destination, BankAccount start, decimal amount) {
            //open? enough $$ in account?
            if (destination.IsOpen && start.IsOpen) {
                if (start.Amount >= amount) {
                    start.Amount -= amount;
                    destination.Amount += amount;
                }
                else {
                    Console.WriteLine("Transaction unsuccessful! Not enough $$ in account!");
                }
            }
            else {
                Console.WriteLine("Transaction unsuccessful! One of the accounts is closed!");
            }
        }

        //Cannot be static because it relies on a property OUTSIDE of the method 
        //Static cannot access instance data
        //public void ShipTo(Product product) {
        //    UPS.Ship(product).To(ShippingAddress);
        //}
    }
}
