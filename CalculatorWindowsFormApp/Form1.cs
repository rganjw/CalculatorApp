using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperasi.Items.Add("Penambahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");

            cmbOperasi.SelectedIndex = 0;
        }

        private int Penambahan(int a, int b) => a + b;
        private int Pengurangan(int a, int b) => a - b;
        private int Perkalian(int a, int b) => a * b;
        private int Pembagian(int a, int b) => a / b;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);

            switch (cmbOperasi.SelectedItem.ToString())
            {
                case "Penambahan":
                    txtHasil.Text = Penambahan(a, b).ToString();
                    break;
                case "Pengurangan":
                    txtHasil.Text = Pengurangan(a, b).ToString();
                    break;
                case "Perkalian":
                    txtHasil.Text = Perkalian(a, b).ToString();
                    break;
                case "Pembagian":
                    txtHasil.Text = Pembagian(a, b).ToString();
                    break;
            }
        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNilaiB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
