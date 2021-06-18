using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.145 v
            Console.WriteLine("Введите пожалуйста длинну массива, ваше величество");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[x];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                mas[i] = r.Next(10, 10000);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");
            int b = 0;
            for (int i = 0; i < x / 2; i++)
            {
                b = mas[i];
                mas[i] = mas[x - i - 1];
                mas[x - 1 - i] = b;
            }
            for (int i = 0; i < x; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
