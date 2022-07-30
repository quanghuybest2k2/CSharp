using System;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            int kyTu = 140;
            Console.WriteLine("========================Twitter=======================");
            Console.Write("Moi ban nhap noi dung: ");

            string ChuoiNoiDung = Console.ReadLine();

            Console.Write("Chuoi dai:");

            Console.WriteLine(ChuoiNoiDung.Length);

            if (ChuoiNoiDung.Length < kyTu)
            {
                Console.WriteLine("Chap nhan!");//ACCEPTANCE: chấp nhận
            }
            else
            {
                Console.WriteLine("Tu choi!"); //REFUSAL: từ chối
            }
            Console.ReadLine();
        }
    }
}
