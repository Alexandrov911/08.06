using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.145 b
            Console.WriteLine("ВВедите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-100, 100);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");
            int z = 0;
            for (int i = 0; i < n; i=i + 2)
            {
                z = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = 2;

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();


        }
    }
}
