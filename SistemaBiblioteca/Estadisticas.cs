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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void cbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPrestamo.SelectedIndex == 2) {
                cbEstadistica.Items.Add("A sala");
                cbEstadistica.Items.Add("A domicilo");
            }
            else
            {
                cbEstadistica.Items.Clear();
                cbEstadistica.Items.Add("Cantidad");
                cbEstadistica.Items.Add("Género");
                cbEstadistica.Items.Add("Grupo de edad"); 
            }
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            fechaEstadistica.Format = DateTimePickerFormat.Custom;
            fechaEstadistica.CustomFormat = "MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void fechaEstadistica_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
