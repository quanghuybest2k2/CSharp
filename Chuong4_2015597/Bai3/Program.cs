using System;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            /*viết một chương trình có tên là admissions cho văn phòng tuyển sinh của một trường cao đẳng. Người dùng nhập vào
            điểm trung bình thpt bằng dấu phẩy(ví dụ: 3,2) và một điểm xét tuyển.
            hiển thị thông báo "Accept" nếu học sinh đáp ứng một trong hai điều sau:
            yêu cầu:
            + Điểm trung bình từ 3.0 trở lên và điểm xét tuyển ít nhất là 60
            + Điểm trung bình dưới 3.0 và điểm xét tuyển ít nhất là 80
            + Nếu học sinh không đáp ứng được, hãy hiển thị "Reject"*/

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=================Admission===================");
            Console.Write("Nhập vào điểm trung bình(Số thập phân): ");
            double diemTBNhap = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào điểm xét tuyển: ");
            int diemXTNhap = int.Parse(Console.ReadLine());

            if (diemTBNhap >= 3.0 && diemXTNhap >= 60 || diemTBNhap < 3.0 && diemXTNhap >= 80)
            {
                Console.WriteLine("Accept!");
            }
            else
            {
                Console.WriteLine("Reject!");
            }
            // Accept: Chấp nhận
            // Reject: Bị đánh rớt, không được chọn, từ chối
            Console.ReadLine();
        }
    }
}
