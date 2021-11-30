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
            string a = Console.ReadLine();
            int b=Convert.ToInt32(a);
            int i = 0, p = 0,c, n = 0,d;

            do
            {
                Console.Write("Введите" + i + "число-");
                c = Convert.ToInt32(Console.ReadLine());
                d= Convert.ToInt32(Console.ReadLine());
                if (c > 0)
                    p++;
                if (d < 0)
                    n++;
            } while (i!=0&&i<=b);
            Console.WriteLine("Количество положительных=" +p);
            Console.WriteLine("Количество отрицательных=" + n);
            Console.ReadKey();
        }
    }
}
