using System;
using static System.Console;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopDienVien;
using TopDienVien.Yua_mikami;

namespace namespace_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            TopDienVien.DienVien.thongtin("Takudo", 1998);
            WriteLine(TopDienVien.Yua_mikami.YuaMikami.tenDienVien());
        }
    }
}
