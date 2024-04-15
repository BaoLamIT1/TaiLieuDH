using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
        {
            static void Main(string[] args)
            {
                PTB2 pt = new PTB2();
                string s = pt.giaipt();
                Console.WriteLine(s);
                Console.ReadLine();
            }

        }
    
}
