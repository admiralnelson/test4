using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b = 0;
            int c = 0;
            int d = 0;
            bool p = false;
            bool q = false;
            bool r = false;
            b = Int32.Parse(Console.ReadLine());

            //b = Console.ReadLine();
            //c = Console.ReadLine();
            //Console.WriteLine(a +"\n");
            for (int j = 0; j < b; j++)
            {
                a = Console.ReadLine();
                for(int i=0;i<a.Length;i++)
                {
                    if(a[0]=='1') { p = true; } else { p = false; }
                    if(a[2]=='1') { q = true; } else { q = false; }
                    if (a[4] == '1') { r = true; } else { r = false; }
                }
                if ( p )  { c++; }
                if ( q )  { c++; }
                if (r) { c++; }
                if(c>1) { d++;c = 0; } else { c = 0; }
            }
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
