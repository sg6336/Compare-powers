using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int ComparePowers(int[] a, int[] b)
        {
            //double aaa = Math.Pow(a[0], a[1]);
            //double bbb = Math.Pow(b[0], b[1]);
            double aaa = a[1] * Math.Log(a[0]);
            double bbb = b[1] * Math.Log(b[0]);
            if (aaa == bbb)
            {
                return 0;
            }
            if (aaa > bbb)
            {
                return -1;
            }
            if (aaa < bbb)
            {
                return 1;
            }
            return 0;
        }
    }
}