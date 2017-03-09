using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HOME\PT2017_Sabina_Akpayeva\2\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\HOME\PT2017_Sabina_Akpayeva\2\output.txt");
            string numbers = sr.ReadLine();
            string[] t = numbers.Split();
            int[] arr = new int[2];
            arr[0] = int.Parse(t[0]);
            arr[1] = int.Parse(t[1]);
            int f = 0;
   
           if (arr[0]<arr[1])
           {
                for (int i = 1; i <= arr[0]; i++)
                {
                   if (arr[0] / i == 0 && arr[1] / i == 0)
                    {
                        f = i;
                        Console.Write(f);
                    }
                }
            }

           else
            {
                for (int k = 1; k <= arr[1]; k++)
                {
                    if (arr[0] / k == 0 && arr[1] / k == 0)
                    {
                        Console.Write(k);
                    }
                }
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
