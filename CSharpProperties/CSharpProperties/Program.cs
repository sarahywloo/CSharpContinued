using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties {
    class Program {
        static void Main(string[] args) {
            var handbag = new Product {
                Name = "Saint Laurent Monogram",
                Price = 1290.99m,
            };
            handbag.ApplyDiscount(percent: .10m, flat: 100m);

            Console.WriteLine("{0} Price: {1:c}", handbag.Name, handbag.Price);

            //AddNumbers() Assignment
            var math1 = new Math();
            var sum1 = math1.AddNumbers(5, 5);
            Console.WriteLine("Sum = " + sum1);

            var math2 = new Math();
            var sum2 = math2.AddNumbers(5, 6, 7, 8, 9);
            Console.WriteLine("Sum = " + sum2);

            //Crazy Math Assignment

            Debug.Assert(Math.DoSomething(6, 2) == 3, "Method divides numbers!");
            Debug.Assert(Math.DoSomething(3, 3, 3) == 9, "Method adds numbers!");
            Debug.Assert(Math.DoSomething(2, 2, 2, 2) == 16, "Method multiplies numbers!");

            Console.ReadLine();
        }
    }
}
