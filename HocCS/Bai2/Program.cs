using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KieuChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Khai bao de co the xuat tieng VIet ra man hinh
            //Console.OutputEncoding = Encoding.UTF8;
            //char a = '\u02a5'; //vị trí của ký tự trong bảng mã
            //Console.WriteLine(" Xin chào các bạn " + a);
            //string s = "Xin chao cac ban ";
            //Console.WriteLine(s);
            string hoTen = " Nguyen Van Toan Van";

            //Console.Write("Nhap vao ho va ten ");
            //hoTen = Console.ReadLine();
            Console.WriteLine(hoTen);
            Console.WriteLine(hoTen[5]); // lấy ký tự số 5 (không tính khoảng trắng)
            
            Console.WriteLine(hoTen.ToUpper()); //Hàm viet hoa
            
            Console.WriteLine(hoTen.ToLower()); //Hàm viet thuong

            Console.WriteLine(hoTen.Length); //lấy chiều dài của chuỗi(có tính khoảng trắng)
            
            Console.WriteLine(hoTen.Substring(0, 2));//lấy 1 chuỗi (từ vt 0, lấy 2 ký tự)
            Console.WriteLine(hoTen.Substring(5, 2));//lấy 1 chuỗi (từ vt 5, lấy 2 ký tự)
            
            //Hàm tìm vị trí đầu tiên của một chuỗi con trong chuỗi
            Console.WriteLine(hoTen.IndexOf("Van"));
            
            //Ham tim vi tri sau cung cua chuoi con trong chuoi cha
            Console.WriteLine(hoTen.LastIndexOf("Van"));

            //Hàm xóa khoảng trắng ở đầu và cuối chuỗi
            Console.WriteLine(hoTen.Trim());

            //Hàm cắt chuỗi thành các chuỗi con 
            string[] tu = hoTen.Trim().Split(' ');

            //Hàm thay thế 1 chuỗi thành một chuỗi mới
            Console.WriteLine(hoTen.Replace("Toan", "OOP"));
            //Lấy họ
            Console.WriteLine(" Ho la " + tu[0]);
            Console.ReadKey();
        }
    }
}