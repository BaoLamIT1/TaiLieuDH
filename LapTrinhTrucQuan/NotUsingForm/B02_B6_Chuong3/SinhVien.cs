using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_B6_Chuong3
{
     class SinhVien
    {
        string ma, ht;
        int ns;
        float lt, csdl;

        public string Ma { get => ma; set => ma = value; }

        public SinhVien()
        {
            lt = 0; csdl = 0;
        }
        public void nhap()
        {
            Console.Write("Nhap ma sv: ");
            ma=Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            ns = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem lap trinh: ");
            lt = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem csdl: ");
            csdl = float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine(ma+" " + ht + " " + ns.ToString() + " " + TB().ToString());
        }

        public SinhVien(string ma, string ht, int ns, float lt, float csdl)
        {
            this.ma = ma;
            this.ht = ht;
            this.ns = ns;
            this.lt = lt;
            this.csdl = csdl;
        }

        public float TB()
        {
            return (lt + csdl) / 2;
        }
                
    }
}
