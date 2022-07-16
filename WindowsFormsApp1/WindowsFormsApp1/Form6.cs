using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            


            if (Prenos.DoktorSamo == "Kardiolog")
            {
                label1.Text = "Kardiolog";
                
            }

            if(Prenos.DoktorSamo == "Dermatolog")
            {
                label1.Text = "Dermatolog";
                
            }
            openFileDialog1.FileName = "";
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            if (Prenos.DoktorSamo == "Kardiolog")
            {
                label1.Text = "Kardiolog";
                openFileDialog1.InitialDirectory = @"C:\Users\ognje\source\repos\WindowsFormsApp1\Kardiolog";
            }
            if (Prenos.DoktorSamo == "Dermatolog")
            {
                label1.Text = "Dermatolog";
                openFileDialog1.InitialDirectory = @"C:\Users\ognje\source\repos\WindowsFormsApp1\Dermatolog";
            }
            openFileDialog1.Filter = "txt fajlovi|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((Prenos.DoktorSamo == "Dermatolog" && openFileDialog1.InitialDirectory.Contains("Dermatolog")) 
                    || (Prenos.DoktorSamo == "Kardiolog" && openFileDialog1.InitialDirectory.Contains("Kardiolog")))
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                    richTextBox1.Text = "Pogresni folder";

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
                MessageBox.Show("Nisi izabrao slucaj");
            else
            {
                File.Delete(openFileDialog1.FileName);
                richTextBox1.Clear();
                MessageBox.Show("Uspesno si obrisao slucaj");
            }
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
