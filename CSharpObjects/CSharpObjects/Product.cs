using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects {
    class Product {

        //auto-implemented property
        public string Name { get; set; }
        public decimal Price { get; set; }
        //full property:
        //private decimal _price;
        //public string Price {
        //  get {
        //      return _price.ToString("c");
        //}
        //  set {
        //      _price = decimal.Parse(value);
        //}
        //}
        public string Description { get; set; }
        public int UnitsInStock { get; set; }

        //full property, where you can access the backing field
        
        public decimal TotalPrice {
            get {
                return Price * 1.08m;
            }
        }

        public void DoSomething() {

        }
    }
}
