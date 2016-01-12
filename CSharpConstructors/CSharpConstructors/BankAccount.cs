using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors {
    class BankAccount {
        public string ID { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }

        public BankAccount() { }

    }
}
