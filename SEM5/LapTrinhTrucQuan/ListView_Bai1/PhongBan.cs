using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_Bai1
{
    internal class PhongBan
    {
        string ma, ten;

        public PhongBan(string ma =" ", string ten = " ")
        {
            this.ma = ma;
            this.ten = ten;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Contains(string m)
        {
            if (string.CompareOrdinal(ma, m) == 0)
                return 0;
            return 1;
        }
    }
}
