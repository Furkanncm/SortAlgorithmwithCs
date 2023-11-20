using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 19, 10, 3, 45, 6, 23 };

            for(int i = 0; i<arr.Length; i++)
            {
                for(int j = 1; j<arr.Length; j++)
                {
                    if (arr[j]<arr[j-1])
                    {
                        int temp = arr[j];
                        arr[j]=arr[j-1];
                        arr[j-1]=temp;
                    }
                    
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
                 
            
        }
    }
}
