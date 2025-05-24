using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_B6_Chuong3
{
    class DSSV
    {
        int n; // so sinh vien
        SinhVien[] ds;

        public DSSV()
        {
            n = 0;
        }

        public DSSV(int n, SinhVien[] ds)
        {
            this.n = n;
            this.ds = ds;
        }
        public void nhap()
        {
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            ds = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap diem cho sinh vien thu {i+1}"); ds[i] = new SinhVien();
                ds[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("\nDS SV \n");
            foreach (SinhVien x in ds) x.xuat();
        }
        public void TBT8()
        {
            bool k = false;
            Console.WriteLine("cac sv tren 8");
            for(int i=0;i<n;i++)
                if (ds[i].TB ()> 8)
                {
                    k = true;
                    ds[i].xuat();
                }
            if (k == false) Console.WriteLine("k co sv co diem tren 8");
            
        }
    }
}
