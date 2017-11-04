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
        Conexion con;
        public Libros()
        {
            InitializeComponent();
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");
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
            String error = validarCampos();
            if (error.Equals(""))
            {

                if (textNombre.Text == "")
                {
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(error, "Registro Prestamo Libro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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
            string error = "";
            if (TextCedula.Text.Trim() == "" || TextCedula.Text.Trim().Length > 10)
            {
                MessageBox.Show("El campo cédula no puede estar vacio o ser mayor a 10 digitos\n", "Registro Cubículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                BuscarCliente();
                if (textNombre.Text != "")
                {
                    button2.Enabled = true;
                    button4.Enabled = true;
                }

            }
        }

        private String validarCampos()
        {
            string error = "";
            if (TextCedula.Text.Trim() == "")
            {
                error += "*El campo cédula no puede estar vacio.\n";
            }
            if (TextCedula.Text.Trim().Length > 10)
            {
                error += "*El campo cédula no puede tener mas de 10 caracteres.\n";
            }
            if (textLibro.Text.Trim() == "")
            {
                error += "*El campo Libro no puede estar vacio.\n";
            }
            if (textLibro.Text.Trim().Length > 40)
            {
                error += "*El campo Libro no puede tener mas de 40 caracteres.\n";
            }
            if (CB_encargado.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione un encargado Válido.\n";
            }
            if (CB_automizado.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione una Opción Válida en el campo automatizado.\n";
            }
            if (CB_tipo.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione Un Tipo Válido\n";
            }
            if (CB_beneficiarios.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione una cantidad de beneficiarios Válida\n";
            }


            return error;
        }

        private void BuscarCliente()
        {
            try
            {

                con.Abrir();
                con.CargarQuery("select * from cliente where cedula ='" + TextCedula.Text.Trim() + "%';");
                int count = 0;

                IDataReader reader = con.GetSalida();
                while (reader.Read())
                {
                    count += 1;
                    textNombre.Text = reader["nombre"].ToString();
                    textApellido.Text = reader["apellido"].ToString();
                }
                if (count == 0)
                {
                    MessageBox.Show("La busqueda no obtuvo resultados.Digite una Cédula Válida");
                    textNombre.Text = "";
                    textApellido.Text = "";
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error");
                textNombre.Text = "";
                textApellido.Text = "";

            }
            finally
            {
                con.Cerrar();
            }
        }


    }
}
