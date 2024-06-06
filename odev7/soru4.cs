using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class soru4
    {
        int toplam_terim_sayisi;
        int[] katsayilar;
        int[] kuvvetler;

        public soru4(int toplam_terim_sayisi, int[] katsayilar, int[] kuvvetler)
        {
            this.toplam_terim_sayisi = toplam_terim_sayisi;
            this.katsayilar = katsayilar;
            this.kuvvetler = kuvvetler;
        }
        public void polinomYaz(soru4 p)
        {
            String P = "P=";
            for (int i = 0; i < toplam_terim_sayisi; i++)
            {
                if (i < p.toplam_terim_sayisi - 1)
                {
                    P += p.katsayilar[i] + "x^" + p.kuvvetler[i] + "+";
                }
                else if (p.kuvvetler[i]==1) {
                    P += p.katsayilar[i] ;
                }
                else
                {
                    P += p.katsayilar[i] + "x^" +   p.kuvvetler[i];
                }

            }
            Console.WriteLine(P);
            Console.ReadKey();
        }
        public bool polinomKontrol(soru4 p)
        {
            for (int i = 0; i < p.toplam_terim_sayisi; i++)
            {
                if (p.katsayilar[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

       public bool polinomKontrol(soru4 p, soru4 q)
        {

            if (p.toplam_terim_sayisi != q.toplam_terim_sayisi) { return false; }
            for (int i = 0; i < p.toplam_terim_sayisi; i++)
            {
                if (p.katsayilar[i] != q.katsayilar[i]) { return false; }
                if (p.kuvvetler[i] != q.kuvvetler[i]) { return false; }

            }

            return true;
        }

        public void polinomunkatsayılar(soru4 p, int n)
        {
            int x= p.kuvvetler[p.kuvvetler.Length-1];
            int y = p.katsayilar.Length;
            for (int i = 0; i < y; i++)
            {
                if (i==y-1 && x==1 ) { }
                else
                p.katsayilar[i] += n;
            }
            polinomYaz(p);

        }
        public void polinomunsabit(soru4 p, int n)
        {

            if (p.kuvvetler[p.kuvvetler.Length-1]==1)
                p.katsayilar[p.katsayilar.Length-1] += n;
            
            polinomYaz(p);

        }

    }
}
