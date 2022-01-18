using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Viết một ứng dụng có tên là Hurricane để xuất ra một cơn bão dựa 
             trên đầu vào của người dùng về tốc độ gió.
             Bão cấp 5: >= 157 mile/h
             Bão cấp 4: >= 130 mile/h
             Bão cấp 3: >= 111 mile/h
             Bão cấp 2: >= 96 mile/h
             Bão cấp 1: >= 74 mile/h
             Không phải bảo: < 74 mile/h */

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=====================Hurricane======================");
            Console.Write("Nhập vào tốc độ gió: ");
            int gioNhap = int.Parse(Console.ReadLine());

            if (gioNhap >= 157)
            {
                Console.WriteLine("Bão cấp 5");
            }
            else if (gioNhap >= 130)
            {
                Console.WriteLine("Bão cấp 4");
            }
            else if (gioNhap >= 111)
            {
                Console.WriteLine("Bão cấp 3");
            }
            else if (gioNhap >= 96)
            {
                Console.WriteLine("Bão cấp 2");
            }
            else if (gioNhap >= 74)
            {
                Console.WriteLine("Bão cấp 1");
            }
            else
            {
                Console.WriteLine("Không phải bão");
            }
            Console.ReadLine();
        }
    }
}
