using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать массив дробных чисел в диапазоне -1 до 1
            //вывести на экран
           // отсортировать по возрастанию
            //поменять меятами первый и последний элементы
            //вывестии на экран результат работы программы
            Console.WriteLine("ВВедите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-100, 100) / 100.0;
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n -i- 1; j++)
                {
                    if(mas[j]>mas[j + 1])
                    {
                        double p = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = p;
                    }
                }
            }
            double k = mas[0];
            mas[0] = mas[n - 1];
            mas[n - 1] = k;
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
