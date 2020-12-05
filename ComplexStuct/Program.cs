using System;

namespace ComplexStuct
{
    partial class Program
    {
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
            Console.WriteLine("Введите два вещественных числа для первого комплексного числа:");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            ComplexClass complexClass1 = new ComplexClass(num1, num2);

            Console.WriteLine("Введите два вещественных числа для второго комплексного числа:");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            ComplexClass complexClass2 = new ComplexClass(num1, num2);

            Console.WriteLine("Введите нужное действие (вычитание -, сложение +, умножение *):");
            string act = Console.ReadLine();

            Console.Write("Первое комплексное число: ");
            complex1.Print();
            Console.Write("Второе комплексное число: ");
            complex2.Print();

            ComplexClass classResult = new ComplexClass();
            switch (act)
            {
                case "-":
                    classResult = complexClass1.Minus(complexClass2);
                    Console.Write("Результат вычитания комплексных чисел: ");
                    break;
                case "+":
                    classResult = complexClass1.Plus(complexClass2);
                    Console.Write("Результат сложения комплексных чисел: ");
                     break;
                case "*":
                    classResult = complexClass1.Multi(complexClass2);
                    Console.Write("Результат умножения комплексных чисел: ");
                    break;
            }
            classResult.Print();
            #endregion
            Console.ReadKey();
        }
    }
}
