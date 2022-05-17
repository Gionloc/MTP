using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        List<Echipament> lista_jucatori = new List<Echipament>();
        public static Echipament fotbalist_nou;
        public static Echipament fotbalist_nou1;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.ShowDialog();
            Button btn = new Button();
            btn.Text = Form2.fotbalist_nou.Model;
            btn.Width = 200;
            btn.Tag = Form2.fotbalist_nou;
            lista_jucatori.Add(Form2.fotbalist_nou);// se atribuie un obiect de tip Jucator
            flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Echipament j = (Echipament)btn.Tag;
            
                
            propertyGrid1.SelectedObject = j;
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Echipament ech in lista_jucatori)
            {
                var pozitie_teren = (Cat)Enum.Parse(typeof(Cat), comboBox1.SelectedIndex.ToString());
                if (ech.Categorie == pozitie_teren)
                {
                    Button btn = new Button();
                    btn.Text = ech.Model;
                    btn.Width = 200;


                    btn.Tag = ech;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\Echipament.txt", false);
            foreach (Echipament ech in lista_jucatori)
            {
                sw.WriteLine("Numar inventar: " + ech.NrInventar);
                sw.WriteLine("Model: " + ech.Model);
                sw.WriteLine("Categorie: " + ech.Categorie);
                sw.WriteLine("Producator: " + ech.Producator);
                sw.WriteLine("Nume responsabil: " + ech.Nume);
                sw.WriteLine("CNP: " + ech.cnp);
                sw.WriteLine("");
            }
            sw.Close();
            Process.Start("notepad.exe", dir + "\\Echipament.txt");
        }
    }
}
