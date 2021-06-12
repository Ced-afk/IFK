using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace IFK_Bibliothek
{
    public class Buchauflistung
    {
        private  DataSet myXmlDataSet;
        private  DataTable buchTable;
        protected ObservableCollection<Buch> buchliste;


        public Buchauflistung():base()
        {
            buchliste = new ObservableCollection<Buch>();
            FillList();
        }
        public ObservableCollection<Buch> Buchliste
        {
            get { return buchliste; }
            set { buchliste = value; }
        }
        public void FillList()
        {
            buchliste.Add(new Buch("2","Schrödinger","C#","102","Max",new DateTime(2021,2,3)));
            buchliste.Add(new Buch("3", "Kühnel", "Visual Studio", "103", "Van Halen", new DateTime(2021, 2, 3)));
            buchliste.Add(new Buch("4", "Wollenhaupt", "Grappa reist", "104", "Müller", new DateTime(2021, 3, 10)));
        }
        public void Buchlöschen(int l)
        {
            buchliste.RemoveAt(l);
        }
        public void Buchupdate(int u, string a, DateTime dp)
        {
            foreach (Buch buch in buchliste)
            {
                if (buch.Signatur == u.ToString())
                {
                    buch.Person = a;
                    buch.Datum = dp;
                    buch.Frei = false;
                }
            }
        }
        public void Buchrückgabe(String u, DateTime dp)
        {

            foreach (Buch buch in buchliste)
            {
                if (buch.Signatur == u)
                {
                    buch.Datum = dp;
                    buch.Frei = true;
                }
            }
        }
        public void BuchHinzufügen(string i, string a, string t, string s, string p, DateTime dp)
        {
            buchliste.Add(new Buch(i, a, t, s, p, dp));
        }
    }
}
