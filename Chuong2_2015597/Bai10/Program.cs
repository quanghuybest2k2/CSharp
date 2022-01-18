using System;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int phut;
            int h = 60;
            int gio;
            int phutSau;
            Console.WriteLine("===========HoursAndMinutes===========");
            Console.Write("Moi ban nhap so phut: ");
            phut = int.Parse(Console.ReadLine());
            ///Tìm giờ
            gio = phut / h; // lấy phần nguyên thôi (không lấy dư)
            phutSau = phut % h;// chỉ lấy phần dư thôi

            Console.WriteLine("{0} phut la {1}h {2} phut",phut,gio,phutSau);
            Console.ReadLine();
            // vd: 90 phut la 1h 30 phut
        }
    }
}
