using System;

namespace TopDienVien
{
    public class DienVien
    {
        public static void thongtin(string tenDV, int namSinh){
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine($"Diễn viên: {tenDV}\n Tuổi: {tuoi}");
        }
    }
    namespace Yua_mikami{
        public class YuaMikami
        {
            public static string tenDienVien(){
                return "Xin chào Yua Mikami";
            }
        }
    }
}