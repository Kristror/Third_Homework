using System;

namespace ComplexStuct
{
    partial class Program
    {
        struct ComplexStruct
        {
            public double re;
            public double im;

            public ComplexStruct(double re, double im)
            {
                this.re = re;
                this.im = im;
            }

            public ComplexStruct Minus(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public ComplexStruct Plus(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public ComplexStruct Multi(ComplexStruct x)
            {
                ComplexStruct y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public void Print()
            {
                if (im > 0) Console.WriteLine($"{re} + {im}i");
                else Console.WriteLine($"{re} - {im * -1}i");
            }
        }
    }
}
