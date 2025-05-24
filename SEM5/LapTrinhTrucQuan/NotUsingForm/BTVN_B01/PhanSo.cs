using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_B01
{
    class PhanSo
    {
        int tu;
        int mau;
        public PhanSo()
        {
            tu = 1;
            mau = 1;
        }

        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap tu: ");
            tu = int.Parse(Console.ReadLine()); ;

            do
            {
                Console.WriteLine("Nhap mau: ");
                mau = int.Parse(Console.ReadLine());
            }
            while (mau == 0);
        }
        public string xuat()
        {
            string s = "";
            s = tu.ToString() + "/" + mau.ToString();
            return s;
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo  R = new PhanSo();
            R.tu = this.tu * p.mau + this.mau * this.tu;
            R.mau = this.mau*p.mau;
            return R;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo R = new PhanSo();
            R.tu = this.tu * p.mau - this.mau * this.tu;
            R.mau = this.mau * p.mau;
            return R;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo R = new PhanSo();
            R.tu = this.tu * p.tu;
            R.mau = this.mau * p.mau;
            return R;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo R = new PhanSo();
            R.tu = this.tu * p.mau;
            R.mau = this.mau * p.tu;
            return R;
        }
    }
     internal class phanso
    {
        static void Main(string[] args)
        {
            PhanSo p = new PhanSo();
            PhanSo q = new PhanSo();
            p.nhap();
            Console.WriteLine(p.xuat());
            q.nhap();
            Console.WriteLine(q.xuat());

            Console.WriteLine("Tong 2 pso: " + p.Cong(q).xuat());
            Console.WriteLine("Hieu 2 pso: " + p.Tru(q).xuat());
            Console.WriteLine("Tich 2 pso: " + p.Nhan(q).xuat());
            Console.WriteLine("Thuong 2 pso: " + p.Chia(q).xuat());
            Console.ReadKey();
        }
    }
}