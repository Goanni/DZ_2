using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._2
{
    internal class DZ_2
    {
        static void Main()
        {
            Console.WriteLine("Введите размер масива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                m1[i] = rnd.Next(100);
            }
            Console.Write("Исходный массив: ");
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write(m1[i] + " ");
            }
            Console.WriteLine();
            int seredina = size / 2;
            Console.WriteLine(seredina); 
            if(size % 2 == 0)
            {
                for (int i = 0; i < seredina; i++)
                {
                    int vr = m1[i];
                    m1[i] = m1[i + seredina];
                    m1[i + seredina] = vr;
                }
                Console.Write("Итог: ");
                for (int i = 0; i < m1.Length; i++)
                {
                    Console.Write(m1[i] + " ");
                }
            }
            else 
            {
                /*for (int i = 0; i < seredina; i++)
                {
                    int vr = m1[i];
                    m1[i] = m1[i + seredina];
                    m1[i + seredina] = vr;
                }
                for (int i = 0; i < m1.Length; i++)
                {
                    Console.Write(m1[i] + " ");
                }
                int vr2 = m1[size - 1];
                for (int i = size - 2; i > seredina - 1; i--)
                {
                    m1[i + 1] = m1[i];
                }
                m1[seredina] = vr2;*/
               for(int i = 0; i < seredina; i++)
                {
                    int half_index = i + seredina + size % 2;
                    int vr = m1[i];
                    m1[i] = m1[half_index];
                    m1[half_index] = vr;

                }
                Console.Write("Итог: ");
                for (int i = 0; i < m1.Length; i++)
                {
                    Console.Write(m1[i] + " ");
                }
            }
        }
    }
}
