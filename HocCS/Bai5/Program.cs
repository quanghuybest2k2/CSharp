using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int OverLimit = 8000;
            Console.WriteLine("==============CheckCredit==============");
            Console.Write("Moi ban nhap so: ");
            int nhapSo = int.Parse(Console.ReadLine());

            if (nhapSo > OverLimit)
            {
                Console.WriteLine("Vuot gioi han roi!");
            }
            else
            {
                Console.WriteLine("Ok! Chap nhan");
            }

            Console.WriteLine("So la: {0}",nhapSo);

            Console.ReadLine();
        }
    }
}
