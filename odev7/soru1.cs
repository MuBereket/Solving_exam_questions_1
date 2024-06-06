using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class soru1
    {
        public soru1()
        {
            var stack = new Stack1(5);
            stack.Hesapla([3,0,2,0,1,4]);
        }


    }
    internal class Stack1
    {
        int top = -1;
        int[] list;
        int n;
        int kactaneSatdi;
        public Stack1(int n)
        {
            this.list = new int[n];
            this.n = n;
            kactaneSatdi = 0;
        }

        

        public int Top { get => top; set => top = value; }

        public void push(int s)
        {
            if (dolumu())
            {
                Console.WriteLine("Hafıza dolu");
            }
            else
            {
                Top++;
                list[Top] = s;
            }
        }
        public void pop()
        {
            if (bosmu())
            {
                Console.WriteLine("Hafıza boş");
            }
            else
            {
                kactaneSatdi =kactaneSatdi+ list[Top];
                Top--;
            }
        }
        public bool bosmu() { return Top == -1; }
        bool dolumu() { return Top == n; }

        public void Hesapla(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++) {
                if (dizi[i] != 0)
                {
                    push(dizi[i]);
                }
                else {
                pop();
                }
            }

            Console.WriteLine("{0} Parça satıldı", kactaneSatdi);
        }

    }
}