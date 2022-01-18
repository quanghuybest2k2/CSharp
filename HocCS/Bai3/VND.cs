using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class VND
    {
        public static void VNDSangUSD()
        {
            Console.WriteLine("moi nhap VND: ");
            int vndNhap = int.Parse(Console.ReadLine());
            int vnd = vndNhap / 23000;
            Console.WriteLine("{0} VND la {1}USD", vndNhap, vnd);
        }
    }
}
