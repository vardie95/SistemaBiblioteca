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
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class Cubículos : Form
    {
        DateTime fechaHoy = DateTime.Today;
        Conexion con;
        public Cubículos()
        {
            InitializeComponent();
            inicializarFechaActual();
            rbFechaActual.Checked = true;
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.ShowUpDown = true;
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");

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

                AgregarCliente();
                if (textNombre.Text == "")
                {
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(error, "Registro Prestamo Cubículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        private void rbFechaActual_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = false;
            dtFecha.SetDate(DateTime.Today);
            dtHora.Enabled = false;
            dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = true;
            dtHora.Enabled = true;
        }

        private void rbFechaActual_CheckedChanged_1(object sender, EventArgs e)
        {
            dtFecha.Enabled = false;
            dtHora.Enabled = false;
            dtFecha.SetDate(fechaHoy);
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
        private void AgregarCliente()
        {
            try
            {
                con.Abrir();
                string error = validarCampos();
                if (error == "")
                {
                    con.CargarQuery("INSERT INTO `cubiculo`(`cubiculo`, `fecha`, `horaInicio`, `finalidad`, `beneficiarios`, `encargado`, `cedula`) " +
                        " VALUES ('" + CB_cubiculo.SelectedItem.ToString() + "', '" + fechaHoy.ToString() + "', '" + dtHora.Text + "', '" + textFinalidad.Text.Trim() +
                        "', '" + CB_beneficiarios.SelectedItem.ToString() + "', '" + CB_encargado.SelectedItem.ToString() + "', '" + TextCedula.Text.Trim() + "');");
                    con.GetSalida().Close();
                    MessageBox.Show("Prestamo Cubículo registrado");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show(error, "Error");
                }

            }
            catch (MySqlException ex)
            {
                int errorNum = ex.Number;
                if (errorNum == 1452) MessageBox.Show("Error: Revisar la cédula Ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Error: " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Cerrar();
            }
        }
        private void limpiarCampos()
        {
            TextCedula.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textFinalidad.Text = "";
            CB_beneficiarios.SelectedIndex = -1;
            CB_cubiculo.SelectedIndex = -1;
            CB_encargado.SelectedIndex = -1;
        }
        private DataTable InicializarTabla()
        {
            DataTable tablaSalida = new DataTable();
            tablaSalida.Columns.Add(new DataColumn("Cédula"));
            tablaSalida.Columns.Add(new DataColumn("Nombre"));
            tablaSalida.Columns.Add(new DataColumn("Apellido"));
            tablaSalida.Columns.Add(new DataColumn("Hora Inicio"));
            tablaSalida.Columns.Add(new DataColumn("Beneficiarios"));
            tablaSalida.Columns.Add(new DataColumn("Cubículo"));
            tablaSalida.Columns.Add(new DataColumn("Finalidad"));
            tablaSalida.Columns.Add(new DataColumn("Encargado"));
            return tablaSalida;
        }
      

    }  


}
