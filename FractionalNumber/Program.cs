using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalNumber
{
    class Program
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
            public double Decimal()
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

        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            /// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
            /// *Добавить свойства типа int для доступа к числителю и знаменателю;
            /// *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
            /// **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            /// ***Добавить упрощение дробей.
            ///

            Console.WriteLine("Программа для работы с дробями");
            Console.WriteLine("Введите целую часть первого дробного числа:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числитель первого дробного числа:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первого дробного числа:");
            int num3 = int.Parse(Console.ReadLine());
            Fraction fraction1 = null;
            try
            {
                fraction1 = new Fraction(num2 + (num1 * num3), num3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Введите целую часть второго дробного числа:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числитель второго дробного числа:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второго дробного числа:");
            num3 = int.Parse(Console.ReadLine());
            Fraction fraction2 = null;
            try
            {
                fraction2 = new Fraction(num2 + (num1 * num3), num3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Введите нужное действие (сложение +, вычитание -, умножение *, деление /):");
            string act = Console.ReadLine();

            Console.WriteLine($"Первое комплексное число: {fraction1.String()}");

            Console.WriteLine($"Второе комплексное число: {fraction2.String()}");

            Fraction result = null;
            bool checkchar = true;
            switch (act)
            {
                case "+":
                    result = fraction1.Plus(fraction2);
                    Console.Write("Результат сложения дробных чисел: ");
                    break;
                case "-":
                    result = fraction1.Minus(fraction2);
                    Console.Write("Результат вычитания дробных чисел: ");
                    break;
                case "*":
                    result = fraction1.Multi(fraction2);
                    Console.Write("Результат умножения дробных чисел: ");
                    break;
                case "/":
                    result = fraction1.Division(fraction2);
                    Console.Write("Результат деления дробных чисел: ");
                    break;
                default: Console.Write("Введен не правильный символ"); checkchar = false; break;
            }
            if (checkchar)
            {
                Console.WriteLine(result.String());
                Console.WriteLine($"Результат в виде десятичной дроби {result.Decimal():F3}");
                Console.WriteLine($"Результат в виде упрощенной дроби {result.Simplified()}");
            }
            Console.ReadKey();
        }
    }
}
