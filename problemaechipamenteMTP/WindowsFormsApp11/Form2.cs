using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        List<Echipament> lista_jucatori = new List<Echipament>();
        public static Echipament fotbalist_nou;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = true;
            if (textBox5.Text.Trim().Length != 13)
            {
               
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "CNP trebuie completat");
                result = false;
            }
            else
            {
                var pozitie_teren = (Cat)Enum.Parse(typeof(Cat), comboBox1.SelectedIndex.ToString());
                fotbalist_nou = new Echipament(textBox1.Text, textBox2.Text, pozitie_teren, textBox3.Text, textBox4.Text, textBox5.Text);

                lista_jucatori.Add(fotbalist_nou);
            }
        }
    }
}
