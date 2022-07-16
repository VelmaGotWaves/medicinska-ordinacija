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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if(Prenos.PacientDoktor=="Dermatolog")
            saveFileDialog1.InitialDirectory = @"C:\Users\ognje\source\repos\WindowsFormsApp1\Dermatolog";
            else if(Prenos.PacientDoktor=="Kardiolog")
                saveFileDialog1.InitialDirectory = @"C:\Users\ognje\source\repos\WindowsFormsApp1\Kardiolog";
            
            rtbTekst.Text = PrenosDoktora.DatTermina.ToShortDateString();
            rtbTekst.Text += "\nIme: " + PrenosDoktora.Ime + "\n";
            rtbTekst.Text += "Prezime: " + PrenosDoktora.Prezime + "\n";
            rtbTekst.Text += "Pol: " + PrenosDoktora.Pol + "\n";
            rtbTekst.Text += "Datum Rodjenja: " + PrenosDoktora.DatRodjenja + "\n";
            rtbTekst.Text += "Adresa: " + PrenosDoktora.Adresa + "\n";

            rtbTekst.Text += "Problem i dodatne informacije:" + PrenosDoktora.Problem + "\n";
            saveFileDialog1.FileName = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt fajlovi |*.txt";
            if (rtbTekst.Text.Length > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtbTekst.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("Podaci sačuvani");

                    rtbTekst.Clear();
                }
            }
            else
            {
                MessageBox.Show("Nije dozvoljeno čuvanje praznog sadržaja");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
