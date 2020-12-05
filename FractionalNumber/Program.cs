using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalNumber
{
    partial class Program
    {
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
