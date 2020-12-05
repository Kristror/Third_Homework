using System;

namespace FractionalNumber
{
    partial class Program
    {
        class Fraction
        {
            private int numerator;
            private int denominator;

            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                if (denominator != 0) this.denominator = denominator;
                 else this.denominator = 1 ;
            }

            public int Numerator
            {
                get { return numerator; }
                set { numerator = value; }
            }
            public int Denominator
            {
                get { return denominator; }
                set
                {
                    Console.WriteLine("Мы тут");
                    if (value == 0) throw new Exception("Знаменатель не может быть равен 0");
                    else denominator = value;
                }
            }        

            public Fraction Plus(Fraction x)
            {
                int resultNumr = (this.numerator * x.denominator) + (x.numerator * this.denominator);
                int resultDen = this.denominator * x.denominator;
                Fraction result = new Fraction(resultNumr, resultDen);
                return result;
            }
            public Fraction Minus(Fraction x) 
            {
                int resultNumr = (this.numerator * x.denominator) - (x.numerator * this.denominator);
                int resultDen = this.denominator * x.denominator;
                Fraction result = new Fraction(resultNumr, resultDen);
                return result;
            }
            public Fraction Multi(Fraction x)
            {
                int resultNumr = this.numerator * x.numerator;
                int resultDen = this.denominator * x.denominator;
                Fraction result = new Fraction(resultNumr, resultDen);
                return result;
            }
            public Fraction Division(Fraction x)
            {
                int resultNumr = this.numerator * x.denominator;
                int resultDen = this.denominator * x.numerator;
                Fraction result = new Fraction(resultNumr, resultDen);
                return result;
            }

            public string String()
            {
                return $"{this.numerator}/{this.denominator}";
            }
            public double Decimal() //вывод в виде десятичной
            {
                double num = this.numerator;
                double den = this.denominator;
                return num / den;
            }

            public string Simplified()
            {
                if (this.denominator == this.numerator)
                {
                    return "1";
                }
                else
                {
                    int num = this.numerator;
                    int den = this.denominator;
                    int end = (den > num) ? num : den;
                    int GCF = 0; // наибольший общий делитель
                    int whole = 0;

                    for (int i = end; i > 1; i--) //нахождение наибольшего общего делителя
                    {
                        if ((num % i == 0) && (den % i == 0))
                        {
                            GCF = i;
                            break;
                        }
                    }
                    if(GCF!= 0)
                    {
                        num /= GCF;
                        den /= GCF;
                    }
                    while (num / den > 0) //выделение целой части
                    {
                        num %= den;
                        whole++;
                    }
                    if(whole == 0) return $"{num}/{den}";
                    else return $"{whole} {num}/{den}";
                }
            }
        }
    }
}
