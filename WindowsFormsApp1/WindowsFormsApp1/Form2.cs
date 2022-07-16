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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKorisnik.Text == "Kardiolog")
            {
                if (tbSifra.Text == "Kardiolog")
                {
                    Form6 f6 = new Form6();
                    Prenos.DoktorSamo = "Kardiolog";
                    f6.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Uneli ste netačnu lozinku", "GREŠKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSifra.Clear();
                    tbSifra.Focus();

                }
            }
            else if (cmbKorisnik.Text == "Dermatolog")
            {
                if (tbSifra.Text == "Dermatolog")
                {
                    Form6 f6 = new Form6();
                    Prenos.DoktorSamo = "Dermatolog";
                    f6.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Uneli ste netačnu lozinku", "GREŠKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSifra.Clear();
                    tbSifra.Focus();

                }
            }
            else
            {
                MessageBox.Show("Uneli ste korisničko ime koje nije u funkciji", "GREŠKA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbKorisnik.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
