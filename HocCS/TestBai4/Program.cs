using System.IO;
using System;
class GreenvilleRevenue
{
    static void Main()
    {
        Console.Write("So luong thi sinh tham gia nam truoc: ");
        int thiSinhNamTruoc = Convert.ToInt32(Console.ReadLine());
        Console.Write("So luong thi sinh tham gia nam nay: ");
        int thiSinhNamNay = Convert.ToInt32(Console.ReadLine());
        //Thông số
        Console.WriteLine("====================Thong So========================");
        Console.WriteLine("So luong thi sinh nam truoc: {0}", thiSinhNamTruoc);
        Console.WriteLine("So luong thi sinh nam nay: {0}", thiSinhNamNay);
        //So sánh
        if (thiSinhNamTruoc > thiSinhNamNay)
        {
            Console.WriteLine("So luong nam truoc nhieu hon {0} thi sinh so voi nam nay", thiSinhNamTruoc - thiSinhNamNay);
        }
        else
        {
            Console.WriteLine("So luong nam nay nhieu hon {0} thi sinh so voi nam truoc", thiSinhNamNay - thiSinhNamTruoc);
        }
        //Tính doanh thu
        int doanhThu = thiSinhNamNay * 1000000;
        Console.Write("Tong doanh thu nam nay: {0}VND", doanhThu);
        Console.ReadLine();
    }

}