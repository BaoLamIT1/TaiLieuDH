using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_Bai2
{
    internal class MonHoc
    {
        string tenMon;
        int soTC;
        double diem;

        public MonHoc(string tenMon, int soTC, double diem)
        {
            this.tenMon = tenMon;
            this.soTC = soTC;
            this.diem = diem;
        }

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public double Diem { get => diem; set => diem = value; }
    }
}
