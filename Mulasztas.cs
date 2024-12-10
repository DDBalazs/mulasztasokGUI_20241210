using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulasztasokGUI_20241210
{
    internal class Mulasztas
    {
        string nev;
        string osztaly;
        int hanyadika;
        int igazolt;
        int neigazolt;

        public string Nev { get => nev; set => nev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public int Hanyadika { get => hanyadika; set => hanyadika = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Neigazolt { get => neigazolt; set => neigazolt = value; }

        public Mulasztas(string sor)
        {
            string[] db = sor.Split(';');
            nev = db[0];
            osztaly = db[1];
            hanyadika = Convert.ToInt32(db[2]);
            igazolt = Convert.ToInt32(db[3]);
            neigazolt = Convert.ToInt32(db[4]);
        }

        public int NapiHianyzasSzamolas()
        {
            return igazolt+neigazolt;
        }
    }
}
