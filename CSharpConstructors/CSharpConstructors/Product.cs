using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors {
    class Product {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; }

        //creating a constructor in C#
        public Product (string name, decimal price, int unitsInStock) {
            Name = name;
            Price = price;
            UnitsInStock = unitsInStock;
        }

        public Product(string name, decimal price, int unitsInStock, string description) {
            Name = name;
            Price = price;
            UnitsInStock = unitsInStock;
            Description = description;
        }
        



    }
}
