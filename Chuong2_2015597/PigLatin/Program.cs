using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ngôn ngữ PigLatin: xóa chữ cái đầu tiên rồi chuyển ra cuối cùng thêm chữ "ay" 
             vd: "pig" thành "igpay" hay "cat" thành "atcay" */
 
            Console.WriteLine("===================PigLatin===================");
            Console.Write("Moi ban nhap mot ten: ");

            string nhapTen = Console.ReadLine(); // người dùng nhập vào

            nhapTen = nhapTen.Trim(); // xóa khoảng trắng ở đầu và cuối chuỗi

            string chuDau = nhapTen.Substring(0, 1); // cắt chữ cái đầu tiên

            string chuoiSau = nhapTen.Substring(1); // chuỗi ký tự ở sau chữ cái đầu tiên
            
            string ketQua = chuoiSau + chuDau;

            Console.WriteLine("{0} trong ngon ngu Pig Latin la: {1}" + "ay", nhapTen,ketQua);

            Console.ReadLine();
        }
    }
}
