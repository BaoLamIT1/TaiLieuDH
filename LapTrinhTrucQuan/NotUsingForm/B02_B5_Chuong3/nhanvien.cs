using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_B5_Chuong3
{
    class nhanvien
    {
        private string ht, dc;
        private int ns;
        private double lcb, hs, pc, tongtien;

        public nhanvien()
        {
            ht = dc = null;
            ns = 0;
            lcb = hs = pc = tongtien = 0;
        }

        public nhanvien(string ht, string dc, int ns, double lcb, double hs, double pc, double tongtien)
        {
            this.ht = ht;
            this.dc = dc;
            this.ns = ns;
            this.lcb = lcb;
            this.hs = hs;
            this.pc = pc;
            this.tongtien = tongtien;
        }
        public void nhap()
        {
            Console.Write("Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Nam sinh: ");
            ns = int.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            dc = Console.ReadLine();
            Console.Write("Luong co ban: ");
            lcb = double.Parse(Console.ReadLine());
            Console.Write("He so: ");
            hs = double.Parse(Console.ReadLine());
            Console.Write("Phu cap: ");
            pc = double.Parse(Console.ReadLine());
            tongtien = lcb * hs + pc;

        }
        public double TTien()
        {
            return this.tongtien;
        }
        public void xuat()
        {
            Console.WriteLine(ht + " " + ns + " " + dc + " " + lcb + " " + hs + " " + pc);
        }
    }
}
