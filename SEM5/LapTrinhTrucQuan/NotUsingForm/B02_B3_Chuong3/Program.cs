using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_B3_Chuong3
{
    class mang1Chieu
    {
        private int n;
        private int[] a;

        public mang1Chieu(int n, int[] a)
        {
            this.n = n;
            this.a = a;
        }

        public mang1Chieu()
        {
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public void Sx(int thutu)
        {
            if (thutu == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int h = a[i];
                            a[i] = a[j];
                            a[j] = h;
                        }
                    }
                }
            }
            else if (thutu == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] < a[j])
                        {
                            int h = a[i];
                            a[i] = a[j];
                            a[j] = h;
                        }
                    }
                }
            }

        }

        public int timKiem(int m)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == m)
                {
                    return i;
                }
            }
            return -1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            mang1Chieu arr = new mang1Chieu();
            arr.nhap();
            arr.Sx(0);
            arr.xuat();
            Console.WriteLine("\n-------------------");
            arr.Sx(1);
            arr.xuat();
            Console.WriteLine("\nTim kiem: " + arr.timKiem(3));
            Console.ReadKey();
        }
    }
}
