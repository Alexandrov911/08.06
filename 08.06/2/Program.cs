using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.144 v
            //Дан массив. Поменять местами:
            //в) третий и максимальный элементы. Если элементов с максимальным значением несколько, 
            //то в обмене должен участвовать первый из них;
            Console.WriteLine("ВВедите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-100, 100);
                Console.Write(mas[i] + " ");
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[k] < mas[i])
                {
                    k = i;
                }
            }
            int f = mas[2];
            mas[2] = mas[k];
            mas[k] = f;
            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i] + "  ");
            }
            Console.ReadKey();

        }
    }
}
