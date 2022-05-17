using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Departament
    {
        string id;
        string nume_departament;
        string adresa;

        public Departament(string id, string nume_departament, string adresa)
        {
            this.Id = id;
            this.Nume_departament = nume_departament;
            this.Adresa = adresa;
        }

        public string Id { get => id; set => id = value; }
        public string Nume_departament { get => nume_departament; set => nume_departament = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public string Afisare()
        {
            return Id + Nume_departament + Adresa;

        }
    }
}
