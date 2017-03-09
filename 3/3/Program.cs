using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Console.ReadLine());
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            foreach (FileSystemInfo file in files)
            {
                string s = file.Name;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == 't' && s[i + 1] == 'e' && s[i + 2] == 's' && s[i + 3] == 't')
                    {
                        Console.WriteLine(file.Name);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
