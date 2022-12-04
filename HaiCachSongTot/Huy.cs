using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiCachSongTot
{
    public class Huy : Quy
    {
        public override void CachDeSongTot()
        {
            base.CachDeSongTot();
            string three = "Ba là, không được nói xấu sau lưng người khác";
            Console.WriteLine($"{three}");
        }
    }
}
