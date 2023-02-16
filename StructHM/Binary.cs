using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHM
{
    public struct Binary
    {
        public static string DectoBin(uint figure)
        {
            return Convert.ToString(figure, 2);
        }
        public static uint BintoDec(string dec)
        {
            return Convert.ToUInt32(dec, 2);
        }
        public static string DectoHex(uint figure)
        {
            return Convert.ToString(figure, 16);
        }
    }
}
