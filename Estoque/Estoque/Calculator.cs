using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque {
    class Calculator {

        public static int Sum(params int[] values) {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) {
                sum += values[i];
            }

            return sum;
        }

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void TripleOut(int x, out int result) {
            result = x * 3;
        }
    }
}
