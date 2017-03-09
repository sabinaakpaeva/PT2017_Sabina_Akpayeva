using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = Console.ReadLine();
            int t = int.Parse(k);
            for (int i=1; i<=t; i++)
            {
                if(t/i==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(); 
        }
    }
}
