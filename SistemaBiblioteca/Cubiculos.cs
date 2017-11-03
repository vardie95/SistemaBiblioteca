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
    public partial class Cubículos : Form
    {
        
        public Cubículos()
        {
            InitializeComponent();
            InicializarTime();

        }

        //Convierte el datetime en solo hora.
        public void InicializarTime()
        {
            dtCubiculo.Format = DateTimePickerFormat.Time;
            dtCubiculo.ShowUpDown = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            if (TextCedula.Text.Trim() == "" || TextCedula.Text.Trim().Length >10 )
            {
                MessageBox.Show("El campo cédula no puede estar vacio o ser mayor a 10 digitos\n", "Registro Cubículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Valido");
                button2.Enabled = true;
                button4.Enabled = true; 

            }
        }
        private String validarCampos() {
            string error = "";
            if(TextCedula.Text.Trim() == "") {
                error += "*El campo cédula no puede estar vacio.\n";
            }
            if (TextCedula.Text.Trim().Length > 10)
            {
                error += "*El campo cédula no puede tener mas de 10 caracteres.\n";
            }
            if (textFinalidad.Text.Trim() == "")
            {
                error += "*El campo Finalidad no puede estar vacio.\n";
            }
            if (textFinalidad.Text.Trim().Length > 40)
            {
                error += "*El campo Finalidad no puede tener mas de 40 caracteres.\n";
            }
            if (CB_encargado.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione un encargado Válido.\n";
            }
            if (CB_beneficiarios.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione la cantidad de Beneficiarios Válida.\n";
            }
            if (CB_cubiculo.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione Un Cubículo Válido\n";
            }


            return error;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String error = validarCampos();
            if (error.Equals(""))
            {

                MessageBox.Show("Validado");
                button2.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                MessageBox.Show(error, "Registro Prestamo Cubículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}
