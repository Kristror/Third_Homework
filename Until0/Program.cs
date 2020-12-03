using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Until0
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Домашняя работа Безукладникова Даниила
            ///
            /// С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            /// Требуется подсчитать сумму всех нечётных положительных чисел. 
            /// Сами числа и сумму вывести на экран, используя tryParse.
            ///

            Console.WriteLine("Программа по подсчету суммы всех нечетных положительных чисел");
            double sum = 0;
            double num;
            do
            {
                bool isNum = double.TryParse(Console.ReadLine().Replace('.',','), out num);
                if (isNum) sum += (num > 0) && (num % 2 != 0) ? num : 0;
                else 
                {
                    Console.WriteLine("Вы вели не число");
                    num = -1;
                };
            } while (num != 0);

            Console.WriteLine($"Cумма всех введенных нечетных положительных чисел: {sum:F2}");

            Console.ReadKey();
        }
    }
}
