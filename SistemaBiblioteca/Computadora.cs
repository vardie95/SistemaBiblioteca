using MySql.Data.MySqlClient;
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
        Conexion con;

        public Computadora()
        {
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");




            InitializeComponent();
            inicializarFechaActual();
            rbFechaActual.Checked = true;
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.ShowUpDown = true;

            limpiarCampos();
            CargarPrestamos("");


        }



        private void inicializarFechaActual()
        {

            lblHoy.Text = fechaHoy.ToString("D", CultureInfo.CreateSpecificCulture("es-MX"));
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Form1().Show();
        }

        private void rbFechaActual_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = false;
            dtFecha.SetDate(DateTime.Today);
            dtHora.Enabled = false;
            dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void rbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            dtFecha.Enabled = true;
            dtHora.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (TextCedula.Text.Trim() == "")
            {
                MessageBox.Show("El campo cédula no puede estar vacio\n", "Registro Cubículo");
            }
            else
            {
                BuscarCliente();
                if (textNombre.Text != "")
                {
                    btnAgregar.Enabled = true;
                }

            }
        }

        private void BuscarCliente()
        {
            try
            {

                con.Abrir();
                con.CargarQuery("select * from cliente where cedula ='" + TextCedula.Text.Trim() + "';");
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
                    btnAgregar.Enabled = false;
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
            if (cbEncargado.SelectedIndex.Equals(-1))
            {
                error += "*Seleccione un encargado Válido.\n";
            }
            if (txtComputadora.Text == "")
            {
                error += "*El campo computadora no puede estar vacio.\n";
            }
            if (txtBeneficiario.Text == "")
            {
                error += "*El campo beneficiario no puede estar vacio.\n";
            }


            return error;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
            if (textNombre.Text == "")
            {
                btnAgregar.Enabled = false;
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
                    string fecha = dtFecha.SelectionEnd.ToString("d/MM/yyyy");
                    con.CargarQuery("INSERT INTO `computadoras`(`computadora`, `fecha`, `horaInicio`, `beneficiarios`, `encargado`, `cedula`) " +
                        " VALUES ('" + txtComputadora.Text.Trim() + "', '" + fecha + "', '" + dtHora.Text +
                        "', '" + txtBeneficiario.Text.Trim() + "', '" + cbEncargado.SelectedItem.ToString() + "', '" + TextCedula.Text.Trim() + "');");
                    con.GetSalida().Close();
                    MessageBox.Show("Prestamo computadora registrado");
                    limpiarCampos();
                    CargarPrestamos("");
                }
                else
                {
                    MessageBox.Show(error, "Registro Prestamo Cubículo");
                }

            }
            catch (MySqlException ex)
            {
                int errorNum = ex.Number;
                if (errorNum == 1452) MessageBox.Show("Error: Revisar la cédula Ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            txtComputadora.Text = "";
            txtBeneficiario.Text = "";
            cbEncargado.SelectedIndex = -1;
            btnAgregar.Enabled = false;

        }

        private void timerHora_Tick_1(object sender, EventArgs e)
        {
            if (rbFechaActual.Checked == true)
            {
                dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            }

        }

        private void CargarPrestamos(string fecha)
        {
            try
            {
                dgComputadora.Columns.Clear();
                con.Abrir();
                if (fecha == "")
                {
                    con.CargarQuery("SELECT computadoras.id, computadoras.computadora, computadoras.Fecha, computadoras.horaInicio, computadoras.horaFin," +
                        " computadoras.beneficiarios, computadoras.encargado, computadoras.cedula, cliente.Nombre, cliente.Apellido FROM" +
                        " `computadoras`,`cliente` WHERE computadoras.cedula = cliente.cedula;");
                }
                else
                {
                    con.CargarQuery("SELECT computadoras.id, computadoras.computadora, computadoras.Fecha, computadoras.horaInicio, computadoras.horaFin," +
                        " computadoras.beneficiarios, computadoras.encargado, computadoras.cedula, cliente.Nombre, cliente.Apellido FROM" +
                        " `computadoras`,`cliente` WHERE computadoras.cedula = cliente.cedula AND computadoras.Fecha like '%/"+ fecha + "';");
                }
                DataTable tablaCliente = InicializarTabla();
                IDataReader reader = con.GetSalida();
                DataRow row;
                while (reader.Read())
                {
                    row = tablaCliente.NewRow();
                    row["id"] = reader["id"].ToString();
                    row["Fecha"] = reader["Fecha"].ToString();
                    row["Computadora"] = reader["computadora"].ToString();
                    row["Cedula"] = reader["cedula"].ToString();
                    row["Nombre"] = reader["Nombre"].ToString();
                    row["Apellido"] = reader["Apellido"].ToString();
                    row["Hora inicio"] = reader["horaInicio"].ToString();
                    row["Hora fin"] = reader["horaFin"].ToString();
                    row["Beneficiarios"] = reader["beneficiarios"].ToString();
                    row["Encargado"] = reader["encargado"].ToString();

                    tablaCliente.Rows.Add(row);
                }
                dgComputadora.Columns.Clear();
                dgComputadora.DataSource = tablaCliente;
                dgComputadora.Columns["id"].Visible = false;
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

        private DataTable InicializarTabla()
        {
            DataTable tablaSalida = new DataTable();
            tablaSalida.Columns.Add(new DataColumn("id"));
            tablaSalida.Columns.Add(new DataColumn("Fecha"));
            tablaSalida.Columns.Add(new DataColumn("Computadora"));
            tablaSalida.Columns.Add(new DataColumn("Cedula"));
            tablaSalida.Columns.Add(new DataColumn("Nombre"));
            tablaSalida.Columns.Add(new DataColumn("Apellido"));
            tablaSalida.Columns.Add(new DataColumn("Hora inicio"));
            tablaSalida.Columns.Add(new DataColumn("Hora fin"));
            tablaSalida.Columns.Add(new DataColumn("Beneficiarios"));
            tablaSalida.Columns.Add(new DataColumn("Encargado"));

            return tablaSalida;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgComputadora.CurrentCell.RowIndex;
                con.Abrir();
                string id = dgComputadora.Rows[index].Cells["id"].Value.ToString();
                con.CargarQuery("UPDATE computadoras SET horaFin= '"+dtHora.Text+"' WHERE computadoras.id = "+id+";");
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
                int index = dgComputadora.CurrentCell.RowIndex;
                con.Abrir();
                string id = dgComputadora.Rows[index].Cells["id"].Value.ToString();
                con.CargarQuery("DELETE FROM `computadoras` WHERE id =" + id + "; ");
                con.GetSalida().Close();
                MessageBox.Show("Prestamo eliminado");
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

        private void filtrarMes_Click(object sender, EventArgs e)
        {
            string fecha = dtFecha.SelectionEnd.ToString("MM/yyyy");
            CargarPrestamos(fecha);
        }
    }
}
