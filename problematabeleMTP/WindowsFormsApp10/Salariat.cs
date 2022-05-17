using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Salariat
    {
        string id;
        string id_departament;
        string nume;
        string post;
        string salariu;
        string data_angajarii;

        public Salariat(string id, string id_departament, string nume,string post,string salariu, string data_angajarii)
        {
            this.Id = id;
            this.Id_departament = id_departament;
            this.Nume = nume;
            this.Post = post;
            this.Salariu = salariu;
            this.Data_angajarii = data_angajarii;
        }

        public string Id { get => id; set => id = value; }
        public string Id_departament { get => id_departament; set => id_departament = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Post { get => id; set => id = value; }
        public string Salariu { get => salariu; set => salariu= value; }
        public string Data_angajarii { get => data_angajarii; set => data_angajarii = value; }

        public string Afisare()
        {
            return "Id:"+Id + " Id_departament:"+Id_departament + " Nume:"+Nume + " Post:"+Post +" Salariu:" + Salariu +"Data angajarii:"+ Data_angajarii;

        }
    }
}
