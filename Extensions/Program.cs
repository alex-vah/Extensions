using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class Enumerable
    {
        public static char[] _ToCharArray(this string a)
        {
            char[] chars = new char[a.Length];
            for(int i = 0; i<a.Length; i++)
            {
                foreach(char j in a)
                {
                    chars[i] = j;
                    i++;
                }
            }
            return chars;

        }
        public static string _Concat(this string a, string b)
        {
            return a + b;
        }
        public static string _Empty()
        {
            return "";
        }
        public static int _Max(this int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int _Min(this int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

    }
}