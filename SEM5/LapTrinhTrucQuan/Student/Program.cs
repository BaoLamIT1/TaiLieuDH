using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class student
    {
        string id;
        string name;
        int dob;
        float lt, csdl,web;

        public student() {
            lt = 0; csdl = 0; web = 0;
        }

        public student(string id, string name, int dob, float lt, float csdl,float web)
        {
            this.Id = id;
            this.name = name;
            this.dob = dob;
            this.lt = lt;
            this.csdl = csdl;
            this.web = web;
        }

        public string Id { get => id; set => id = value; }

        public float TB()
        { return (lt + csdl+web) / 3;  }

        public void nhap ()
        {
            Console.WriteLine("Nhap ma sv: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            dob = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh: ");
            lt = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem csdl: ");
            csdl = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem thiet ke web: ");
            web = int.Parse(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine(id + " "+ name +" "+ dob.ToString()+" "+TB().ToString());
        } 


    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DSSV dSSV = new DSSV();
            dSSV.nhap();
            dSSV.LietKe();
            dSSV.SapXep();
            Console.ReadLine();
        }
    }
}
