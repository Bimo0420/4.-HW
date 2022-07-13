using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0)
            {
                for (int i = 1; i < n; i++)
                
                Console.WriteLine("Квадрат чисел от 1 до {0} равен: {1}", n, i*i);
            }
            else
            {
                Console.WriteLine("Не верный ввод");
            }
            Console.ReadKey();
        }
    }
}
