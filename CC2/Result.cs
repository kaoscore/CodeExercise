using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    public class Result
    {
        public static bool ValidateInput(int t1, int t2, int n)
        {
            if(t1 < 0 || t2 < 0) return false;
            if(t1 > 2 || t2 > 2) return false;
            if(n < 3 || n > 20) return false;
            return true;

        }
        public static int FindNthFibonacciNumber(int t1, int t2, int n)
        {
            if(!ValidateInput(t1, t2, n))
            {
                return -1;
            }

            int[] sequence= new int[n];
            sequence[0]=t1;
            sequence[1]=t2;

            for(int i = 2; i < n;i++)
            {
                sequence[i] = sequence[i-2] + (int)Math.Pow(sequence[i-1] , 2);
            }
            return sequence[n-1];
        }
        public static int FindNthFibonacciNumberRecursive(int t1, int t2, int n)
        {
            if(n==2)
            {
                return t2;
            }
            else if (n == 1)
            {
                return t1;
            }
            else if (n == 0)
            {
                return n;
            }
            else
            {
                return ((int)Math.Pow(FindNthFibonacciNumberRecursive(t1,t2,n - 1),2) + FindNthFibonacciNumberRecursive(t1,t2,n - 2));
            }
        }
    }
}
