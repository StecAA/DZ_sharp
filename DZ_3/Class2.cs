
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
      public  class Complex
    {

        public int a, b;
        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }
        public override string ToString()
        {
            return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(re: x.a - y.a, im: x.b - y.b);
        }
        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }
        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(re: (y.a * x.a) + (y.a * x.b), im: (y.b * x.a) + (y.b * x.b));
        }
    }
}
