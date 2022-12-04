using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaiCachSongTot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Huy huy = new Huy();
            huy.CachDeSongTot();
            Console.ReadLine();
        }
    }
}
