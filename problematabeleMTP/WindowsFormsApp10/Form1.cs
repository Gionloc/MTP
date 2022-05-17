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

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        List<Departament> list_departament = new List<Departament>();
        List<Salariat> list_salariat = new List<Salariat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void departamentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salariatDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salariatDataSet1.Salariat' table. You can move, or remove it, as needed.
            this.salariatTableAdapter.Fill(this.salariatDataSet1.Salariat);
            // TODO: This line of code loads data into the 'salariatDataSet1.Departament' table. You can move, or remove it, as needed.
            this.departamentTableAdapter.Fill(this.salariatDataSet1.Departament);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salariat s = new Salariat(textBox4.Text, textBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            list_salariat.Add(s);
            salariatTableAdapter.Insert(textBox4.Text, textBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            tableAdapterManager.UpdateAll(salariatDataSet1);
            salariatTableAdapter.Fill(salariatDataSet1.Salariat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Departament d = new Departament(textBox1.Text, textBox2.Text, textBox3.Text);
            list_departament.Add(d);
            departamentTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text);
            tableAdapterManager.UpdateAll(salariatDataSet1);
            departamentTableAdapter.Fill(salariatDataSet1.Departament);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DataRowView drv in salariatBindingSource.List)
            {


                string img1 = (string)drv["Id"];
                string img2 = (string)drv["Nume"];
                string img3 = (string)drv["Post"];
                string img4 = (string)drv["Salariu"];
                string img5 = (string)drv["Data_anagajarii"];
                string img = (string)drv["Id_departament"];
                if (img == textBox5.Text)
                {
                    listBox1.Items.Add("Id: " + img1 + " Id_departament:" + img+" Post:"+img3+" Salariu:"+img4+" Data angajarii:"+img5);
                } 
                    
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\Statistica.txt", false);
            foreach (DataRowView d in departamentBindingSource.List)
            {
                foreach (DataRowView s in salariatBindingSource.List)
                {
                    
                        string img1 = (string)s["Id"];
                        string img2 = (string)s["Nume"];
                        string img3 = (string)s["Post"];
                        string img4 = (string)s["Salariu"];
                        string img5 = (string)s["Data_anagajarii"];
                        string img = (string)s["Id_departament"];
                        string img6 = (string)d["Id"];
                        string img7 = (string)d["Id_departament"];
                        string img8 = (string)d["Adresa"];
                    if (img == img6)
                    {
                        count += 1;
                        sw.WriteLine("Id :" + img6);
                        sw.WriteLine("Nume :" + img7);
                        sw.WriteLine("Adresa :" + img8);
                        sw.WriteLine("               ");

                        sw.WriteLine("Id Salariat: " + img1);
                        sw.WriteLine("Id Departament Salariat: " + img);
                        sw.WriteLine("Nume Salariat: " + img2);
                        sw.WriteLine("Post: " + img3);
                        sw.WriteLine("Salariu : " + img4);
                        sw.WriteLine("Data angajarii:" + img5);
                    }

                    }


                }
                sw.WriteLine("Deprtamentul are:" + count + " salariati");
                sw.WriteLine("------------------");
                count = 0;

            
            sw.Close();

            Process.Start("notepad.exe", dir + "\\Statistica.txt");
        }
    }
}

