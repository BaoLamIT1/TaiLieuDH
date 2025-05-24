using System;

namespace Demo1
{
    class PTB2
    {
        double a, b, c;
        public PTB2()
        {
            do
            {
                Console.Write("nhap a: ");
                a = double.Parse(Console.ReadLine());
            } while (a == 0);
            Console.Write("nhap b: ");
            //c2
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap c: ");
            //c3
            bool k = double.TryParse(Console.ReadLine(), out c);

        }

        public PTB2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string giaipt()
        {
            string s = " ";
            double d = b * b - 4 * a * c;
            if (d < 0) s = "PTVN";
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(d)) / 2 / a;
                x2 = (-b - Math.Sqrt(d)) / 2 / a;
                s = "x1 = " + x1.ToString() + "x2 = " + x2.ToString();
            }
            return s;
        }
    }
    
}
