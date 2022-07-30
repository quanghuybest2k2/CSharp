using System;
using System.Text;


namespace CheckMonth
{
    class Program
    {
        enum thang
        {
            thangMot = 1, thangHai, thangBa, thangTu, thangNam, thangSau, thangBay, thangTam, thangChin, thangMuoi, thangMuoiMot, thangMuoiHai
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("========================CheckMonth====================");
            Console.Write("Nhập vào tháng sinh của bạn: ");
            int thangNhap = int.Parse(Console.ReadLine());
            
            if (thangNhap < 12 && thangNhap > 1)
            {
                Console.WriteLine("tháng {0} là tháng hợp Lệ",thangNhap);
            }
            else
            {
                Console.WriteLine("Lỗi");
            }
            Console.ReadLine();
        }
    }
}
