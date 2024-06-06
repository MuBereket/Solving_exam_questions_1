using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class soru3
    {
        int x;
        int y;
        public soru3(int y, int x)
        {
            this.x = x;
            this.y = y;
        }

        public void yazdir()
        {
            Console.WriteLine("Koordinat noktası ({0},{1})", x, y);
            Console.ReadKey();
        }

        public void Xyazdir()
        {
            Console.WriteLine("X noktası ={0}", x);
            Console.ReadKey();
        }

        public void Yyazdir()
        {
            Console.WriteLine("Y noktası ={0}", y);
            Console.ReadKey();
        }
    }
}
