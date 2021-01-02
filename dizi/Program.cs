using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[a];
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(b);
            }
            int[] yd = new int[a];
            for (int i = 0; i < d.Length; i++)
            {
                yd[yd.Length - 1 - i] = d[i];
            }
            foreach (int x in d)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------");
            foreach (int y in yd)
            {
                Console.WriteLine(y);
            }
        }
    }
}
