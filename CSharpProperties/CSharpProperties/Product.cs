using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties {
    class Product {

        public string Name { get; set; }
        public decimal Price { get; set; }

        //Add =0m to make it an optional parameter
        public void ApplyDiscount(decimal percent = 0m, decimal flat = 0m) {
            //do not need to use this.Price here
            Price = Price * (1 - percent) - flat;
        }

        public void ApplyDiscount(string percent = "0", string flat = "0") {
            ApplyDiscount(decimal.Parse(percent), decimal.Parse(flat));
        }
    }
}
