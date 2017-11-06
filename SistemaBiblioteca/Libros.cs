using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class Libros : Form
    {
        Conexion con;
        DateTime fechaHoy = DateTime.Today;
        Form1 inicio;
        public Libros(Form1 inicio)
        {
            this.inicio = inicio;
            InitializeComponent();
            inicializarFechaActual();
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");
            rbFechaActual.Checked = true;
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.ShowUpDown = true;
            CargarPrestamos("");
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
            String error = validarCampos();
            if (error.Equals(""))
            {
                AgregarCliente();
                if (textNombre.Text == "")
                {
                    button2.Enabled = false;
                  
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
                    btnFinalizar.Enabled = true;
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
                    btnFinalizar.Enabled = false;
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

        private void dtHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = true;
            dtHora.Enabled = true;
        }

        private void rbFechaActual_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = false;
            dtFecha.SetDate(DateTime.Today);
            dtHora.Enabled = false;
            dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void AgregarCliente()
        {
            try
            {
                con.Abrir();
                string error = validarCampos();
                if (error == "")
                {

                    string fecha = dtHora.Text +" "+ dtFecha.SelectionEnd.ToString("d/MM/yyyy");
                    con.CargarQuery("INSERT INTO `libro`(`libro`, `tipo`, `encargado`, `beneficiarios`, `automatizado`, `fechaPrestamo`,`cedula`)" +
                        " VALUES ('" + textLibro.Text.Trim() + "', '" + CB_tipo.SelectedItem.ToString() + "', '" + CB_encargado.SelectedItem.ToString()+  "', '"+
                         CB_beneficiarios.SelectedItem.ToString() + "', '" + CB_automizado.SelectedItem.ToString() + "', '"+ fecha + "', '"+TextCedula.Text.Trim()+"');");
                    con.GetSalida().Close();
                    MessageBox.Show("Prestamo Cubículo registrado");
                    limpiarCampos();
                    CargarPrestamos("");
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
            textLibro.Text = "";
            CB_beneficiarios.SelectedIndex = -1;
            CB_tipo.SelectedIndex = -1;
            CB_encargado.SelectedIndex = -1;
            CB_automizado.SelectedIndex = -1;
        }
        private DataTable InicializarTabla()
        {
            DataTable tablaSalida = new DataTable();
            tablaSalida.Columns.Add(new DataColumn("id"));
            tablaSalida.Columns.Add(new DataColumn("Cédula"));
            tablaSalida.Columns.Add(new DataColumn("Nombre"));
            tablaSalida.Columns.Add(new DataColumn("Apellido"));
            tablaSalida.Columns.Add(new DataColumn("libro"));
            tablaSalida.Columns.Add(new DataColumn("Fecha Inicio"));
            tablaSalida.Columns.Add(new DataColumn("Fecha Fin"));
            tablaSalida.Columns.Add(new DataColumn("Tipo"));
            tablaSalida.Columns.Add(new DataColumn("Beneficiarios"));
            tablaSalida.Columns.Add(new DataColumn("Automatizado"));
            tablaSalida.Columns.Add(new DataColumn("Encargado"));
            return tablaSalida;
        }



        private void CargarPrestamos(string fecha)
        {
            try
            {

                con.Abrir();
                if (fecha == "")
                {
                    con.CargarQuery("SELECT libro.id,cliente.cedula,cliente.Nombre,cliente.Apellido,libro.libro,libro.fechaPrestamo" +
                        ",libro.fechaDevolucion,libro.tipo,libro.beneficiarios,libro.automatizado, libro.encargado FROM libro,cliente WHERE " +
                        "cliente.cedula=libro.cedula;");
                }
                else
                {
                    con.CargarQuery("SELECT libro.id,cliente.cedula,cliente.Nombre,cliente.Apellido,libro.libro,libro.fechaPrestamo" +
                        ",libro.fechaDevolucion,libro.tipo,libro.beneficiarios,libro.automatizado, libro.encargado FROM libro,cliente WHERE " +
                        "cliente.cedula=libro.cedula AND libro.fechaPrestamo like '%/" + fecha + "';");
                }

                DataTable tablaCliente = InicializarTabla();

                IDataReader reader = con.GetSalida();
                DataRow row;
                while (reader.Read())
                {
                    row = tablaCliente.NewRow();
                    row["id"] = reader["id"].ToString();
                    row["Cédula"] = reader["cedula"].ToString();
                    row["Nombre"] = reader["nombre"].ToString();
                    row["Apellido"] = reader["apellido"].ToString();
                    row["Libro"] = reader["libro"].ToString();
                    row["Fecha Inicio"] = reader["fechaPrestamo"].ToString();
                    row["Fecha Fin"] = reader["fechaDevolucion"].ToString();
                    row["Tipo"] = reader["tipo"].ToString();
                    row["Beneficiarios"] = reader["beneficiarios"].ToString();
                    row["Automatizado"] = reader["automatizado"].ToString();
                    row["Encargado"] = reader["encargado"].ToString();
                    tablaCliente.Rows.Add(row);
                }
                dgLibros.Columns.Clear();
                dgLibros.DataSource = tablaCliente;
                dgLibros.Columns["id"].Visible = false;
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgLibros.CurrentCell.RowIndex;
                con.Abrir();
                string fecha = dtHora.Text + " " + dtFecha.SelectionEnd.ToString("d/MM/yyyy");
                string id = dgLibros.Rows[index].Cells["id"].Value.ToString();
                con.CargarQuery("UPDATE libro SET fechaDevolucion = '" + fecha + "' WHERE  libro.id = " + id + ";");
                con.GetSalida().Close();
                MessageBox.Show("Prestamo finalizado");
                CargarPrestamos("");


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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgLibros.CurrentCell.RowIndex;
                string fechaFin = dgLibros.Rows[index].Cells["Fecha Fin"].Value.ToString();
                if (fechaFin.Equals(""))
                {
                    MessageBox.Show("Primero debe finalizar el prestamo");


                }
                else
                {
                    con.Abrir();
                    string id = dgLibros.Rows[index].Cells["id"].Value.ToString();
                    con.CargarQuery("DELETE FROM `libro` WHERE id =" + id + "; ");
                    con.GetSalida().Close();
                    MessageBox.Show("Prestamo eliminado");
                    CargarPrestamos("");
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

        private void filtrarMes_Click(object sender, EventArgs e)
        {
            if(filtrarMes.Text == "Cancelar")
            {
                CargarPrestamos("");
                filtrarMes.Text = "Filtrar por mes";
            }
            else
            {
                string fecha = dtFecha.SelectionEnd.ToString("MM/yyyy");
                CargarPrestamos(fecha);
                filtrarMes.Text = "Cancelar";
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            if (rbFechaActual.Checked == true)
            {
                dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            }
        }

        private void Libros_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }
    }
}
