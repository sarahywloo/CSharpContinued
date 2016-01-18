﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties {
    class Math {
        public int AddNumbers(int num1, int num2) {
            return num1 + num2;
        }
        public int AddNumbers (params int[] numbers) {
            int sum = 0;
            foreach (int n in numbers) {
                sum = sum + n;
            }
            return sum;
        }

        //Crazy Math Assignment
        public static int DoSomething(int n1, int n2) {
            return n1 / n2;
        }
        public static int DoSomething(int n1, int n2, int n3) {
            return n1 + n2 + n3;
        }
        public static int DoSomething(int n1, int n2, int n3, int n4) {
            return n1 * n2 * n3 * n4;
        }
    }
}
