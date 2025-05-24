using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class DSSV
    {
        int n;
        student[] ds;
        public DSSV()
        {
            n = 0;
        }

        public DSSV(int n, student[] ds)
        {
            this.n = n;
            this.ds = ds;
        }
        public void nhap ()
        {
            Console.WriteLine("Nhap danh sach sinh vien: ");
            n = int.Parse(Console.ReadLine());

            ds = new student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap diem cho sinh vien thu " +i + 1);
                ds[i] = new student();
                ds[i].nhap();
            }
        }

        public void xuat()
        {
            for (int i = 0;i < n;i++)
            {
                Console.WriteLine("Danh sach sinh vien: ");
                ds[i].xuat();

            }
        }

        public void LietKe()
        {
            bool k = true;

            Console.WriteLine("Diem TB >8");
            for (int i = 0; i<=n ; i++) 
            {
                if (ds[i].TB() >8)
                {
                    k = true;
                    ds[i].xuat();
                }

            }
            if (k==false) { Console.WriteLine("Khong co ! "); }
        }

        public void SapXep()
        {
            for(int i = 0; i<=n ; i++)
            {
                for (int j = i+1; j<n; j++)
                {
                    if ((ds[i].Id.CompareTo(ds[j].Id)) > 0)
                    {
                        string temp = ds[i].Id;
                        ds[i].Id = ds[j].Id;
                        ds[j].Id = temp;
                    }
                }
            }
            for (int i = 0; i <n; i++)
            {
                ds[i].xuat();
            }
           
        }
    }
}
