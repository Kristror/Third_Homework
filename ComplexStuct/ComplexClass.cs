using System;

namespace ComplexStuct
{
    partial class Program
    {
        class ComplexClass
        {
            private double re;
            private double im;
            public ComplexClass()
            {
                re = 0;
                im = 0;
            }

            public ComplexClass(double re, double im)
            {
                this.re = re;
                this.im = im;
            }
            public ComplexClass Plus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.re = x.re + re;
                y.im = x.im + im;                
                return y;
            }
            public ComplexClass Minus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();                
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public ComplexClass Multi(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public double Re
            {
                get { return re; }
                set { re = value; }
            }
            public double Im
            {
                get { return im; }
                set { im = value; }
            }

            public void Print()
            {
                if (im > 0) Console.WriteLine($"{re} + {im}i");
                else Console.WriteLine($"{re} - {im * -1}i");
            }
        }
    }
}
