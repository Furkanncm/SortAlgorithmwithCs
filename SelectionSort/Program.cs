using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 7, 14, 2, 10 };
            for(int i = 0; i<arr.Length-1;i++)
            {
                int min = i;

                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[j]<arr[min])
                    {
                        min=j;
                    }
                }

                int temp = arr[min];
                arr[min]=arr[i];
                arr[i]=temp;
               


            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
          
        }
    }
}
