using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_B2_Chuong3
{
    class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
            x = 0; y = 0;
        }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void nhap()
        {
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("(x,y) = (" + x.ToString() + " , " + y.ToString() + ")");
        }

        public double Kc(Diem a)
        {
            double d = Math.Sqrt(this.x * a.x + this.y * a.y);
            return d;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Diem a = new Diem();
            Diem b = new Diem();
            a.nhap(); b.nhap();
            a.xuat(); b.xuat();
            Console.WriteLine("Khoang cach giua 2 diem: " + a.Kc(b));
            Console.ReadKey();
        }
    }
}
