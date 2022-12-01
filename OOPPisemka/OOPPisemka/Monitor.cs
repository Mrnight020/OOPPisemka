using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPisemka
{
    class Monitor
    {
        string velikost;
        string typ;
        string znacka;
        public string Rozliseni { get; }
        public int Cena { get; }

        public Monitor()
        {

        }
        public Monitor(string velikost, string typ, string znacka, string rozliseni, int cena)
        {
            this.velikost = velikost;
            this.typ = typ;
            this.znacka = znacka;
            Rozliseni = rozliseni;
            Cena = cena;
        }

        public string VratRozliseni()
        {
            return Rozliseni;
        }


        public string ZmenaZnacky(string znacka)
        {
            this.znacka = znacka;
            return znacka;
        }


        public override string ToString()
        {
            return String.Format("{0}  monitor ma velikost {1} , stoji {2} kc , a ma rozliseni {3}",znacka,velikost,Cena,Rozliseni);
        }
    }
}
