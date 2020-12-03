using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexStuct
{
    class Program
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


        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            /// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.            
            /// в) Добавить диалог с использованием switch демонстрирующий работу класса.
            ///
            #region структуры
            Console.WriteLine("Программа по вычислению комплексных чисел");
            Console.WriteLine("Работа со структурой");
            ComplexStruct complex1 = new ComplexStruct(5, 4);
            ComplexStruct complex2 = new ComplexStruct(2, -6);

            Console.Write("Первое комплексное число: ");
            complex1.Print();
            Console.Write("Второе комплексное число: ");
            complex2.Print();

            ComplexStruct result = complex1.Plus(complex2);
            Console.Write("Результат сложения комплексных чисел: ");
            result.Print();

            result = complex1.Minus(complex2);
            Console.Write("Результат вычитания комплексных чисел: ");
            result.Print();

            result = complex1.Multi(complex2);
            Console.Write("Результат умножения комплексных чисел: ");
            result.Print();
            #endregion
            #region класс           
            Console.WriteLine("Введите два вещественных числа для первого компелксного числа:");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            ComplexClass complexClass1 = new ComplexClass(num1, num2);

            Console.WriteLine("Введите два вещественных числа для второго компелксного числа:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            ComplexClass complexClass2 = new ComplexClass(num1, num2);

            Console.WriteLine("Введите нужное действие (вычитание -, сложение +, умножение *):");
            string act = Console.ReadLine();

            Console.Write("Первое комплексное число: ");
            complex1.Print();
            Console.Write("Второе комплексное число: ");
            complex2.Print();

            ComplexClass ClassResult = new ComplexClass();
            switch (act)
            {
                case "-":
                    ClassResult = complexClass1.Minus(complexClass2);
                    Console.Write("Результат вычитания комплексных чисел: ");
                    break;
                case "+":
                    ClassResult = complexClass1.Plus(complexClass2);
                    Console.Write("Результат сложения комплексных чисел: ");
                     break;
                case "*":
                    ClassResult = complexClass1.Multi(complexClass2);
                    Console.Write("Результат умножения комплексных чисел: ");
                    break;
            }
            ClassResult.Print();
            #endregion
            Console.ReadKey();
        }
    }
}
