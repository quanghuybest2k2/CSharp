using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int OverLimit = 8000;
            Console.WriteLine("================CheckCredit================");
            Console.Write("Moi ban nhap gia mat hang: ");
            int nhapSo = int.Parse(Console.ReadLine());

            if (nhapSo > OverLimit)
            {
                Console.WriteLine("error! Vuot gio han!");
            }
            else
            {
                Console.WriteLine("ok! Chap nhan");
            }
            Console.ReadLine();
            
        }
    }
}
