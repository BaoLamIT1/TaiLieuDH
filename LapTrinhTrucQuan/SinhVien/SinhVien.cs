using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class Student
    {
        string id;
        string name;
        string dob;
        string address;
        double math;
        double chemistry;
        double physics;
        double avg;

        public string msv
        {
            get { return msv; }
            set { msv = value; }
        }
        public double DTB
        {
            get { return DTB; }
            set { DTB = value; }
        }

        public Student()
        {
            Console.WriteLine("Insert id: ");
            id = Console.ReadLine();
            Console.WriteLine("Insert name: ");
            name = Console.ReadLine();
            Console.WriteLine("Insert DoB: ");
            dob = Console.ReadLine();
            Console.WriteLine("Insert address: ");
            address = Console.ReadLine();
            Console.WriteLine("Insert math: ");
            math = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert physics: ");
            physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert chemistry: ");
            chemistry = double.Parse(Console.ReadLine());

            avg = (math + physics + chemistry) / 3;
        }


        public Student(string id, string name, string address, double math, double chemistry, double physics, double avg)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.math = math;
            this.chemistry = chemistry;
            this.physics = physics;
            avg = avg;
        }

        public void xuat()
        {
            Console.WriteLine("Information: "+ id +" "+name +" "+dob+" "+address+" "+math+" "+chemistry+" "+physics);
        }
    }

    internal class SinhVien
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                student.Add(new Student());
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("List: "); 
            foreach ( Student st in student )
            {
                st.xuat();
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Sinh vien co ma 211: ");
            foreach (Student st in student)
            {
                if (st.msv == "211")
                    st.xuat();
                else
                    Console.WriteLine("Khong co");
            }
            Console.WriteLine("Average point >=7 : ");
            foreach ( Student st in student )
            {
                if (st.DTB >= 7) 
                {
                    st.xuat();
                }
                Console.ReadKey();
            }
        }
    }

}
