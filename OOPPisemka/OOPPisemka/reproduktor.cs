using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPisemka
{
    class reproduktor
    {
        int cena;
        string znacka;
        bool vodeodolny;
        public int Hlasitost { get; }
        public int Cena {
            get
            {
                return 0;
            }
            set
            {
                cena = value;
            }
        }

        public reproduktor()
        { }

        public reproduktor(int cena, string znacka, bool vodeodolny, int hlasitost)
        {
            this.cena = cena;
            this.znacka = znacka;
            this.vodeodolny = vodeodolny;
            Hlasitost = hlasitost;
        }

        public void zmenaznacky(string znacka)
        {
            this.znacka = znacka;
        }
        public void zmenaceny(int cena)
        {
            this.cena = cena;
        }

        public override string ToString()
        {
            return String.Format("{0}  reproduktor stoji {1} , {2} vodeodolny , jeho hlasitost ma {3} decibel", znacka, cena, vodeodolny?"je":"neni" ,Hlasitost);
        }


    }
}
