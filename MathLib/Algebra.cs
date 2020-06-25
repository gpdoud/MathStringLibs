using System;

namespace MathLib {
    public class Algebra {

        public double Inverse(double a) {
            if(a == 0) {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            return 1 / a;

        }
        public int Modulo(int a, int b) {
            return a - (a / b * b);
        }
        public long Cubed(int a) {
            return a * a * a;

        }
    }
}
