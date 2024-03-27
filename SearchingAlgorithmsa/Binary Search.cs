using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithmsa
{
    internal class Binary_Search
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int n = 6;//size of array
            int x = 10;//value 
            Console.WriteLine(fun(arr, n, x));
        }
        static int fun(int[] arr, int n, int x)
        {
            int low = 0;//pointer 
            int high = n - 1;//pointer
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;

                }

            }
            return -1;
        }
    }
}
