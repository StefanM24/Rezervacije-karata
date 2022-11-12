using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervacije_karata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(new object[] { "Njujork", "Dubai", "Hurgada" });
            comboBox3.Items.AddRange(new object[] { "Ekonomska", "Biznis", "Prva" });
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 2)
            {
                string[] stavke = { "Isporuka prtljaga do hotela", "Video igre", "Neograničeno piće", "Luksuzni ručak" };
                listBox1.DataSource = stavke;
                listBox1.SelectedIndex = -1;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum1 = dateTimePicker1.Value;
            DateTime datum2 = dateTimePicker2.Value;
            if (textBox1 == null || textBox2 == null || textBox3 == null || dateTimePicker1 == null || dateTimePicker2 == null || comboBox2 == null || numericUpDown1 == null || comboBox3 == null)
            {
                richTextBox1.AppendText("Niste popunili sva polja.");
            }
            else
            {
                richTextBox1.AppendText("Uspešna rezervacija!" +
                                    "\nIme: " + textBox1.Text +
                                    "\nPrezime: " + textBox2.Text +
                                    "\nTelefon: " + textBox3.Text +
                                    "\nDatum polaska: " + datum1.ToShortDateString() +
                                    "\nDatum povratka: " + datum2.ToShortDateString() +
                                    "\nDestinacija: " + comboBox2.SelectedItem.ToString() +
                                    "\nBroj karata: " + numericUpDown1.Value.ToString() +
                                    "\nKlasa: " + comboBox3.SelectedItem.ToString());
                if (comboBox3.SelectedIndex == 2)
                {
                    richTextBox1.AppendText("\nDodatne pogodnosti: ");
                    foreach (string stavka in listBox1.SelectedItems)
                    {
                        richTextBox1.AppendText("\n" + stavka);
                    }
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                comboBox2.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                comboBox3.SelectedIndex = -1;
                listBox1.SelectedIndex = -1;
            }
            
        }
    }
}
