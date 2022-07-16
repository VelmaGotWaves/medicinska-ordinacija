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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked= true;
            label4.Text=Prenos.PacientDoktor;
            if (Prenos.PacientDoktor == "Kardiolog")
            {
                checkBox1.Text = "bol u grudima";
                checkBox2.Text = "osećaj preskakanja srca";
                checkBox3.Text = "gušenje, otećano disanje";
                checkBox4.Text = "malaksalost, vrtoglavicu";
            }
            if(Prenos.PacientDoktor == "Dermatolog")
            {
                checkBox1.Text = "Uklanjanje izraštaja";
                checkBox2.Text = "Hemijski piling";
                checkBox3.Text = "Tretman lica";
                checkBox4.Text = "Fileri i mezoterapija";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int b = 0;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Unesite Vase Ime");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                b += 1;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Unesite Vase prezime");
            }
            else
            {
                errorProvider2.SetError(textBox2, "");
                b += 1;
            }
            if (dateTimePicker2.Value >= DateTime.Today)
            {
                errorProvider3.SetError(dateTimePicker2, "Unesite validan datum");
            }
            else
            {
                errorProvider3.SetError(dateTimePicker2, "");
                b += 1;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider4.SetError(textBox3, "Unesite Vasu adresu");
            }
            else
            {
                errorProvider4.SetError(textBox3, "");
                b += 1;
            }
            if (dateTimePicker1.Value == DateTime.Today || dateTimePicker1.Value < DateTime.Today)
            {
                errorProvider5.SetError(dateTimePicker1, "Unesite validan datum");
            }
            else
            {
                errorProvider5.SetError(dateTimePicker1, "");
                b += 1;
            }

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || textBox4.Text != "")
            {
                
                errorProvider6.SetError(label9, "");
                b += 1;
            }
            else
            {
                errorProvider6.SetError(label9, "Unesite Bolest");
            }
            if (b == 6)
            {
                PrenosDoktora.Ime = textBox1.Text;
                PrenosDoktora.Prezime = textBox2.Text;
                if (radioButton1.Checked)
                    PrenosDoktora.Pol = radioButton1.Text;
                else if (radioButton2.Checked) PrenosDoktora.Pol = radioButton2.Text;
                PrenosDoktora.DatRodjenja = dateTimePicker2.Value;
                PrenosDoktora.Adresa = textBox3.Text;
                PrenosDoktora.DatTermina = dateTimePicker1.Value;

                if (checkBox1.Checked)
                    PrenosDoktora.Problem += checkBox1.Text + "\n";
                if (checkBox2.Checked)
                    PrenosDoktora.Problem += checkBox1.Text + "\n";
                if (checkBox3.Checked)
                    PrenosDoktora.Problem += checkBox1.Text + "\n";
                if (checkBox4.Checked)
                    PrenosDoktora.Problem += checkBox1.Text + "\n";
                if(textBox4.Text!="")
                    PrenosDoktora.Problem += "\n"+ textBox4.Text + "\n";
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
