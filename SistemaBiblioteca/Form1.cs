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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cubículos obje = new Cubículos();
            obje.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Libros obje = new Libros();
            obje.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrarCliente obje = new registrarCliente();
            obje.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Computadora().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Estadisticas().Show();
        }
    }
}
