using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Echipament
    {
        string nrInventar, model, producator, numeResponsabil, CNP;
        Cat categorie;
        public Echipament( string NrInventar, string Model, Cat Categorie, string Producator, string Nume, string CNP)
        {
            this.nrInventar = NrInventar;
            this.model = Model;
            this.producator = Producator;
            this.categorie = Categorie;
            this.numeResponsabil = Nume;
            
            this.CNP = CNP;
        }
        [Description("Nume"), Category("Date responsabil"), ReadOnly(true)]
        public string Nume
        {
            get { return numeResponsabil; }
            set { numeResponsabil = value; }
        }
        [Description("Numar inventar"), Category("Date echipament"), ReadOnly(true)]
        public string NrInventar
        {
            get { return nrInventar; }
            set { nrInventar = value; }
        }
        [Description("Model"), Category("Date echipament"), ReadOnly(true)]
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        [Description("Producator"), Category("Date echipament"), ReadOnly(true)]
        public string Producator
        {
            get { return producator; }
            set { producator = value; }
        }
        [Description("Categorie"), Category("Date echipament"), ReadOnly(true)]
        public Cat Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        [Description("CNP"), Category("Date responsabil"), ReadOnly(true)]
        public string cnp
        {
            get { return CNP; }
            set { CNP = value; }
        }

    }
    public enum Cat : int
    {
       Calculator,
       Laptop,
       Imprimanta,
       Scaner

    };
}

