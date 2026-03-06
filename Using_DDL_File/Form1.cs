using System;
using System.Windows.Forms;
using Calculation; // Twoja DLL

namespace Using_DDL_File
{
    public partial class Form1 : Form
    {
        // obiekt klasy z DLL
        calculate cal = new calculate();

        public Form1()
        {
            InitializeComponent();
        }

        // Dodawanie
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Odejmowanie
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}