using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    enum Menu
    {
        Thoat, VNDsangUSD, USDsangVND
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ung dung chuyen tien");
                Console.WriteLine("Nhan{0} de thoat", (int)Menu.Thoat);
                Console.WriteLine("Nhan{0} de chuyen tu VND sang USD", (int)Menu.VNDsangUSD);
                Console.WriteLine("Nhan{0} de chuyen tu USD sang VND", (int)Menu.USDsangVND);
                Console.WriteLine("Moi nhap chuc nang: ");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case Menu.Thoat:
                        Console.WriteLine("Da thoat chuong trinh!");
                        return;
                    case Menu.VNDsangUSD:
                        VND.VNDSangUSD();
                        break;
                    case Menu.USDsangVND:
                        USDSangVND();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void USDSangVND()
        {
            Console.WriteLine("moi nhap USD: ");
            int usdNhap = int.Parse(Console.ReadLine());
            int usd = usdNhap * 23000;
            Console.WriteLine("{0} USD la {1}VND", usdNhap,usd);
        }
    }
}
