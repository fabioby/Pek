using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pek
{
    class Pekaru
    {
        private string nev;
        private int ar;
        private bool laktozmentese;

        public Pekaru(string nev, int ar, bool laktozmentese)
        {
            this.nev = nev;
            this.ar = ar;
            this.laktozmentese = laktozmentese;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Laktozmentese { get => laktozmentese; set => laktozmentese = value; }

        public override string ToString()
        {
            return String.Format("{0} ({1}ft / db)", this.nev, this.ar);
        }
    }
}
