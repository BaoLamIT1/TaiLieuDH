using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03_WindowForms
{
    internal class Sach1:Sach
    {
        public string qrcode;
        public Sach1(string ma=" ", string ten=" ", string tg = " ", int sl = 0,string qrcode =" ")
            :base(ma,ten,tg,sl)
        {
            this.qrcode = ma;
        }
        public override string ToString()
        {
            return base.ToString() + " " + qrcode;
        }
        public string Qrcode { get => qrcode; set => qrcode = value; }
    }
}
