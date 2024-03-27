using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithmsa
{
    internal class Linear_search
    {
//        Expected Time Complexity: O(n).
//        Expected Auxiliary Space: O(1). 
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int n = 6;//size of array
            int x = 10;//value 
            Console.WriteLine(fun(arr, n, x));
        }
        static int fun(int[] arr, int n, int x)
        {
            for(int i=0;i<n;i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
