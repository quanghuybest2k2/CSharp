using System;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intA = { 3, 7, 1, 4, 2, 0, 11 };
            int[] tempA = intA;
            Console.Write("Elements of array: ");
            foreach (int i in intA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Đảo mảng
            Array.Reverse(tempA);
            Console.Write("Array after reversed: ");
            foreach (int i in tempA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Sắp xếp mảng
            Array.Sort(intA);
            Console.Write("Array after sorted: ");
            foreach (int i in intA)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
