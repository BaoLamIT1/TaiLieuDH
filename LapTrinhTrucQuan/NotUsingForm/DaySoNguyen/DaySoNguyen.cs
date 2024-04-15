using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySoNguyen
{
    class DaySoNguyen
    {
        int n;
        int[] a;
        public DaySoNguyen()
        {
            n = 0;
            a = new int[0];

        }

        public void nhap()
        {
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + (i + 1) + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine("Day vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + " ");

            }
        

        }
        public void SapXepDay()
        {
            int temp;
            Console.WriteLine("Day duoc sap xep  ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
    class DayNguyen
    {
        static void Main(string[] args)
        {
            DaySoNguyen daySoNguyen = new DaySoNguyen();
            daySoNguyen.nhap();
            daySoNguyen.xuat();
            daySoNguyen.SapXepDay(); daySoNguyen.xuat();
            Console.ReadKey();
        }
    }


}

