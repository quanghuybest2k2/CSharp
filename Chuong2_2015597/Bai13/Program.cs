using System;

namespace MakeChange
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("===========MakeChange===========");
            Console.Write("Moi ban nhap vao dollar: ");
            int inputDollar = int.Parse(Console.ReadLine());
            int cpDollar = inputDollar;
            int twenties = cpDollar / 20; // 113 / 20 -> no lay so 5
            int tens = cpDollar % 20 / 10; // 113 % 20 -> 13 / 10 -> day no lay so 1
            int fives = cpDollar % 10 / 5;
            int ones = cpDollar % 5; // 113 % 5 = 22 du 3 thi no lay so 3 thi 3 ones
            Console.WriteLine("So dollar cua ban nhap : {0} -> Sau khi chuyen doi {1} twenties {2} tens {3} fives {4} ones", inputDollar, twenties, tens, fives, ones);
            Console.ReadLine();
        }
    }
}