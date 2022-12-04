using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiCachSongTot
{
    public class Quy
    {
        public virtual void CachDeSongTot()
        {
            string title = $"Cách để sống tốt:";
            string one = "Một là, không được đổ lỗi cho người khác.";
            string two = "Hai là, không được biện minh cho cái sai của mình.";
            Console.WriteLine($"{title}\n{one}\n{two}");
        }
    }
}
