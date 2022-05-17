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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        int index = 0;
        List<Articol> agenda = new List<Articol>();
        public Form1()
        {
            InitializeComponent();
            TreeNode parentNodeFitness = new TreeNode();
            parentNodeFitness.Name = "parent_1";
            parentNodeFitness.Text = "Imbracaminte fitness";
            treeView1.Nodes.Add(parentNodeFitness);

            TreeNode parentNodeInot = new TreeNode();
            parentNodeInot.Name = "parent_2";
            parentNodeInot.Text = "Accesorii pentru inot";
            treeView1.Nodes.Add(parentNodeInot);

            TreeNode parentNodeCiclism = new TreeNode();
            parentNodeCiclism.Name = "parent_3";
            parentNodeCiclism.Text = "Accesorii ciclism";
            treeView1.Nodes.Add(parentNodeCiclism);

            TreeNode parentNodeIncaltaminte = new TreeNode();
            parentNodeIncaltaminte.Name = "parent_4";
            parentNodeIncaltaminte.Text = "Incaltaminte";
            treeView1.Nodes.Add(parentNodeIncaltaminte);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articol s = new Articol(index, textBox5.Text,textBox4.Text, textBox3.Text, textBox2.Text,textBox1.Text, (Categorie)comboBox2.SelectedIndex);
            index++;




            agenda.Add(s);
            if (comboBox2.Text == "Imbracaminte fitness")
            {
                TreeNode childNode1 = new TreeNode();
                childNode1.Name = s.Nume_produs;
                childNode1.Text = textBox4.Text;
                treeView1.Nodes["parent_1"].Nodes.Add(childNode1);
            }
            if (comboBox2.Text == "Accesorii pentru inot")
            {
                TreeNode childNode2 = new TreeNode();
                childNode2.Name = s.Nume_produs;
                childNode2.Text = textBox4.Text;
                treeView1.Nodes["parent_2"].Nodes.Add(childNode2);
            }
            if (comboBox2.Text == "Accesorii ciclism")
            {
                TreeNode childNode3 = new TreeNode();
                childNode3.Name = s.Nume_produs;
                childNode3.Text = textBox4.Text;
                treeView1.Nodes["parent_3"].Nodes.Add(childNode3);
            }
            if (comboBox2.Text == "Incaltaminte")
            {
                TreeNode childNode4 = new TreeNode();
                childNode4.Name =s.Nume_produs;
                childNode4.Text = textBox4.Text;
                treeView1.Nodes["parent_4"].Nodes.Add(childNode4);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (Articol p in agenda)
            {
                if (treeView1.SelectedNode.Text == p.Nume_produs)
                    propertyGrid1.SelectedObject = p;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\Statistica.txt", false);
            foreach(Articol a in agenda)
            {
                if(a.Categorie1== (Categorie)comboBox1.SelectedIndex)
                {
                    count += 1;
                    sw.WriteLine("Categorie:" + a.Categorie1);
                    sw.WriteLine("Numar inventar: " + a.Nr_inventar);
                    sw.WriteLine("Nume produs: " + a.Nume_produs);
                    sw.WriteLine("Producator: " + a.Producator);
                    sw.WriteLine("Pret: " + a.Pret);
                    sw.WriteLine("Numar bucati : " + a.Nr_bucati);
                    sw.WriteLine("------------------");
                }
               
            }
            sw.WriteLine("Categoria are:" + count + " produse");
            sw.WriteLine("------------------");
            count = 0;
            sw.Close();

            Process.Start("notepad.exe", dir + "\\Statistica.txt");
        }
    }
}
