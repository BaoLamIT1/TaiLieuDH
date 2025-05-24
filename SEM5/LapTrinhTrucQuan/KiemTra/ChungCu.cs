using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class ChungCu
    {
        string diachi;
        int slphong, slwc;
        string huongbancong;
        float giaphong;
        double chietkhau;
        string tinhtrang;

        public ChungCu(string diachi, int slphong, int slwc, string huongbancong, float giaphong, double chietkhau, string tinhtrang)
        {
            this.diachi = diachi;
            this.slphong = slphong;
            this.slwc = slwc;
            this.huongbancong = huongbancong;
            this.giaphong = giaphong;
            this.chietkhau = chietkhau;
           
            this.tinhtrang = tinhtrang;
        }

        public string Diachi { get => diachi; set => diachi = value; }
        public int Slphong { get => slphong; set => slphong = value; }
        public int Slwc { get => slwc; set => slwc = value; }
        public string Huongbancong { get => huongbancong; set => huongbancong = value; }
        public float Giaphong { get => giaphong; set => giaphong = value; }
        public double Chietkhau { get => chietkhau; set => chietkhau = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
