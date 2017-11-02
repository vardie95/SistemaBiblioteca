using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "" || textBox6.Text == "" || comboBox1.SelectedIndex.Equals(-1)|| comboBox2.SelectedIndex.Equals(-1) || comboBox4.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Alguno de los campos esta Incompleto", "Prestamo Libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            }
            else {

                button2.Enabled = false;

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Libros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8)
            {
                button2.Enabled = true;
            }
            else
                MessageBox.Show("Digite una Identificación Válida", "Prestamo Libro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
