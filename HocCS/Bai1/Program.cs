using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd;
            int cr;
            Console.Write("Moi nhap chieu dai: ");
            cd = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap chieu rong: ");
            cr = int.Parse(Console.ReadLine());

            float s = cd * cr;

            Console.WriteLine("Dien tich hinh chu nhat cd = {0} va cr = {1} la: {2}", cd, cr, s);
            Console.ReadLine();
        }
    }
}
