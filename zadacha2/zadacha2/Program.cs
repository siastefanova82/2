using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            Console.WriteLine(Palendrom(x));
        }

        private static bool Palendrom(string x)
        {
            int start = 0;
            int end = x.Length - 1;
            for (int i = 0; i < x.Length / 2; i++)
            {
                if (x[start] != x[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}