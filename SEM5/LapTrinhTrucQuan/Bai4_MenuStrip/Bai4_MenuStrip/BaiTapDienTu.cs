using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_MenuStrip
{
    internal class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;
        public BaiTapDienTu() { }
        public BaiTapDienTu(string debai, string dapan)
        {
            this.debai = debai;
            this.dapan = dapan;
        }
        public BaiTapDienTu(string debai, string dapan, List<string> dapantungcau)
        {
            this.debai = debai;
            this.dapan = dapan;
            this.dapantungcau = dapantungcau;
        }
        public string Debai
        {
            get { return debai; }
            set { debai = value; }
        }
        public string Dapan
        {
            get { return dapan; }
            set { dapan = value; }
        }
      
        public List<string> Dapantungcau
        {
            get { return dapantungcau;  }
            set { dapantungcau = value; }
        }
       
    }
}
