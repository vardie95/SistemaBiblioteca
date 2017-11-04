using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Computadora : Form
    {
        DateTime fechaHoy = DateTime.Today;
        public Computadora()
        {
            InitializeComponent();
            inicializarFechaActual();
        }

        private void inicializarFechaActual()
        {

            lblHoy.Text = fechaHoy.ToString("D", CultureInfo.CreateSpecificCulture("es-MX"));
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
