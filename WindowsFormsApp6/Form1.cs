using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
             Fraction f2= Fraction.Parse(textBox2.Text);
           
            
           textBox1.Text = f1.ToString();
           textBox2.Text = f2.ToString();
           
            
            Fraction risultato= f1.Somma(f2);
            label1.Text=risultato.ToString();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(textBox3.Text);
            listBox1.Items.Add(f);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            Fraction somma = new Fraction(0, 2);

            foreach(Fraction fs in listBox1.Items)
            {
                somma =  fs.Somma(somma);
            }
            lblRisul.Text = somma.ToString();
        }
    }
}
