using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        //Сравнить количество положительных и отрицательных чисел
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел");
            int counterPositive = 0;
            int counterNegative = 0;
            int buffer;
            do
            {
                buffer = Convert.ToInt32(Console.ReadLine());
                if (buffer > 0)
                {
                    counterPositive += 1;
                }
                else
                {
                    if (buffer < 0)
                    {
                        counterNegative += 1;
                    }  
                }
            } while (buffer != 0);
            if (counterPositive > counterNegative)
            {
                Console.WriteLine("Количество положительных чисел больше {0} > {1}", counterPositive, counterNegative);
            }
            else
            {
                if (counterPositive < counterNegative)
                {
                    Console.WriteLine("Количество отрицательных чисел больше {0} > {1}", counterNegative, counterPositive);
                }
                else
                {
                    Console.WriteLine("Количество положительных и отрицательных чисел равно {0} равно {1}", counterNegative, counterPositive);
                }                
            }
            Console.ReadKey();
        }
    }
}
