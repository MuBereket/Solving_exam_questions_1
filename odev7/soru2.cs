using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class soru2
    {
        
        public soru2() {
            Ders ders1 = new Ders(1, "Matematik", 101); 
            Ders ders2 = new Ders( 2, "Fizik",102 );

            Ders[] verilenDersler = { ders1, ders2 };

            Egitmen egitmen = new Egitmen(101, "Ahmet", verilenDersler);

            // Ders ekleme ve verilen dersleri listeleme
            Ders ders3 = new Ders(3, "Kimya", 101);
            egitmen.DersEkle(ders3);

            egitmen.VerilenDersleriListele();

        }

    }

    class Ders {
       public int id;
        public String ders;
        public int egitmen_id;

        public Ders(int id, string ders, int egitmen_id)
        {
            this.id = id;
            this.ders = ders;
            this.egitmen_id = egitmen_id;
        }
    }

    class Egitmen
    {
        public int id;
        public String egitmen;
        public Ders[] verilenders;

        public Egitmen(int id, string egitmen, Ders[] verilenders)
        {
            this.id = id;
            this.egitmen = egitmen;
            this.verilenders = verilenders;

        }
        public void DersEkle(Ders ders)
        {
            // Eğitmene ders ekleme işlemi
            int currentCount = verilenders.Length;
            if (currentCount < 20)
            {
                Array.Resize(ref verilenders, currentCount + 1);
                verilenders[currentCount] = ders;
                Console.WriteLine($"{ders.ders} dersi eğitmene eklendi.");
            }
            else
            {
                Console.WriteLine("Eğitmenin verdiği derslerin maksimum sayısı aşıldı.");
            }
        }
        public void VerilenDersleriListele()
        {
            Console.WriteLine($"{egitmen} adlı eğitmenin verdiği dersler:");
            foreach (var ders in verilenders)
            {
                Console.WriteLine($"{ders.ders}");
            }
        }
    }

}
