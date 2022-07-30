using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ BubbleSort =============");
               Mang_1_Chieu_Sort();
            //int[] a = new int[3];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("Nhap mang: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Phan tu a[{0}]",i);
            //}
            ////Hoan_Vi(ref a[i], ref a[j]);
            Console.ReadLine();
        }
        static void Hoan_Vi(ref int x,ref int y)
        {
            int tempSwap = x;
            x = y;
            y = tempSwap;
        }
        static void Mang_1_Chieu_Sort()
        {
            int[] a = {2,6,8,9,4,5,10,15 };
            
            for (int i = 0; i < a.Length -1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    
                        if (a[i] > a[j])
                    {
                        Hoan_Vi(ref a[i],ref a[j]);
                    }
                }
            }
        }
    }
}
