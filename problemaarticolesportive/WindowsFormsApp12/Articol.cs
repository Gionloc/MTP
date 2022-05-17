using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Articol
    {
        private int index;
        private string nr_inventar;
        private string nume_produs;
        private string producator;
        private string pret;
        private string nr_bucati;

        private Categorie categorie;

        public Articol(int index, string nr_inventar, string nume_produs, string producator, string pret,string nr_bucati, Categorie categorie1)
        {
            this.index = index;
            this.nume_produs = nume_produs;
            this.nr_inventar = nr_inventar;
            this.nr_bucati = nr_bucati;
            this.pret = pret;
            this.producator = producator;
            categorie = categorie1;

        }
        [Description("Numar inventar"), Category("Date produs"), ReadOnly(true)]
        public string Nr_inventar
        {
            get
            {
                return nr_inventar;
            }
        }
        [Description("Index"), Browsable(false)]
        public int Index
        {
            get
            {
                return index;
            }

        }
        [Description("Nume produs"), Category("Date produs"), ReadOnly(true)]
        public string Nume_produs
        {
            get
            {
                return nume_produs;
            }
            set
            {
                nume_produs = value;
            }
        }
        [Description("Producator"), Category("Date produs"), ReadOnly(true)]
        public string Producator
        {
            get { return producator; }
        }

        [Description("Pret"), Category("Date produs")]
        public string Pret
        {
            get
            {
                return pret;
            }
            set
            {
                pret = value;
            }
        }
        [Description("Numar bucati"), Category("Date produs")]
        public string Nr_bucati
        {
            get
            {
                return nr_bucati;
            }
            set
            {
               nr_bucati = value;
            }
        }
        [Description("Categorie"), Category("Date produs")]
        public Categorie Categorie1
        {
            get
            {
                return categorie;
            }
            set
            {
                categorie = value;
            }
        }
    }
    enum Categorie : int
    {
        Imbracaminte_fitness,
        Accesorii_pentru_cnot,
        Accesorii_ciclism,
        Incaltaminte
    };
}

