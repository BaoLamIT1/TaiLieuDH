using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_5_9
{
    internal class MatHang
    {
        string ma, ten;
        int soluong;

        public MatHang(string ma=" ", string ten=" ", int soluong=0)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public int Contains(string m)
        {
            if (string.CompareOrdinal(ma, m) == 0)
                return 0;
            return 1;   
        }
    }
}
