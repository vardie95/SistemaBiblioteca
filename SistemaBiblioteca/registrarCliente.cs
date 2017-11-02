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

    public partial class registrarCliente : Form
    {
        Conexion con;
        public registrarCliente()
        {
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtFechaNacimiento.CustomFormat = "d/MM/yyyy";
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clicVolver(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private string verificarCampos()
        {
            string error = "";
            if (txtCedula.Text.Trim() == "") {
                error += "*El campo cédula no puede estar vacio.\n";
            }
            if (txtCedula.Text.Trim().Length>10)
            {
                error += "*El campo cédula no puede tener mas de 10 caracteres.\n";
            }
            if (txtNombre.Text.Trim() == "")
            {
                error += "*El campo nombre no puede estar vacio.\n";
            }
            if (txtNombre.Text.Trim().Length > 40)
            {
                error += "*El campo nombre no puede tener mas de 40 caracteres.\n";
            }
            if (txtApellido.Text.Trim() == "")
            {
                error += "*El campo apellido no puede estar vacio.\n";
            }
            if (txtApellido.Text.Trim().Length > 40)
            {
                error += "*El campo apellido no puede tener mas de 40 caracteres.\n";
            }

            return error;

        }

        private void AgergarCliente(object sender, EventArgs e)
        {
            try
            {
                con.Abrir();
                string error = verificarCampos();
                if (error == "")
                {

                    MessageBox.Show("Cliente registrado");
                }
                else
                {
                    MessageBox.Show(error,"Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error");

            }
            finally
            {
                con.Cerrar();
            }
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
