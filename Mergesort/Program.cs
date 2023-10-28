using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section4._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[8];
            marks[0] = 80;
            marks[1] = 90;
            marks[2] = 93;
            marks[3] = 76;
            marks[4] = 77;
            marks[5] = 92;
          

            mergeSort(marks, 0, 10 - 1);

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }

        public static void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }

        public static void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n = q - p + 1;
            int n1 = r - q;
            int[] P = new int[n];
            int[] Q = new int[n1];
            for (i = 0; i < n; i++)
            {
                Q[i] = arr[p + i];
            }
            for (j = 0; j < n1; j++)
            {
                Q[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n && j < n1)
            {
                if (P[i] <= Q[j])
                {
                    arr[k] = P[i];
                    i++;
                }
                else
                {
                    arr[k] = Q[j];
                    j++;
                }
                k++;
            }
            while (i < n)
            {
                arr[k] = Q[i];
                i++;
                k++;
            }
            while (j < n1)
            {
                arr[k] = Q[j];
                j++;
                k++;
            }
        }
    }
}






      
