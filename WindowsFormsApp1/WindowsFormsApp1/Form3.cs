using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kardiolog" || comboBox1.Text == "Dermatolog")
            {
                Prenos.PacientDoktor = comboBox1.Text;
                Form4 f4 = new Form4();
                f4.ShowDialog();

            }
            else
            {
                MessageBox.Show("Izabrani lekari nisu u funkciji");
                comboBox1.Focus();
                
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
    }
}