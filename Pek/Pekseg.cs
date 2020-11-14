using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pek
{
    class Pekseg
    {
        private string nev;
        private DateTime alapitva;
        private List<Pekaru> termekek;
        
        public Pekseg(string nev)
        {
            this.Nev = nev;
            this.alapitva = DateTime.Now;
            this.termekek = new List<Pekaru>();
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; }
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Nev, this.Alapitva);
        }
    }
}
