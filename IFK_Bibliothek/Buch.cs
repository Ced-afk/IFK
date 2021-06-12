using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFK_Bibliothek
{
    public class Buch
    {
        protected string iD;
        protected string autor;
        protected string titel;
        protected string signatur;
        protected string person;
        protected DateTime datum;
        protected bool frei = true;

        public Buch(string i, string a, string t, string s, string p, DateTime dp)
        {
            ID = i;
            Autor = a;
            Titel = t;
            Signatur = s;
            Person = p;
            Datum = dp;
        }
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public string Signatur
        {
            get { return signatur; }
            set { signatur = value; }
        }
        public string Person
        {
            get { return person; }
            set { person=value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value;}
        }

        public bool Frei { get => frei; set => frei = value; }
    }
}
