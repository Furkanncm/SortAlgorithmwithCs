using System;

class Program
{
    static void Main()
    {
        // A 
        int[] A = new int[10];
        for (int i = 0; i < 10; i++)
        {
            A[i] = i + 1;
        }

        // B 
        int[] B = new int[10];
        for (int i = 0; i < 10; i++)
        {
            B[i] = 10 - i;
        }

        // C 
        int[] C = new int[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            C[i] = random.Next(1, 11);
        }

        InsertionSort(A);
        InsertionSort(B);
        InsertionSort(C);


        Console.WriteLine("A : " + string.Join(", ", A));
        Console.WriteLine("B : " + string.Join(", ", B));
        Console.WriteLine("C : " + string.Join(", ", C));
    }

    static void InsertionSort(int[] dizi)
    {

        int key;
        for (int i = 1; i<dizi.Length; i++)
        {
            key = dizi[i];
            int j = i-1;

            while (j>=0&&dizi[j]>key)
            {
                dizi[j+1]=dizi[j];
                j=j-1;
            }
            dizi[j+1]=key;

        }
    }

}