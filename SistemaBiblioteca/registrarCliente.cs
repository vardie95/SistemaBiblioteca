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

    public partial class registrarCliente : Form
    {
        Conexion con;
        public registrarCliente()
        {
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");
            InitializeComponent();
            SetMyCustomFormat();
            CargarClientes();
            dgClientes.ReadOnly = true;
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
            if (cbSexo.SelectedIndex < 0)
            {
                error += "*Debe elegir una opción del campo sexo.\n";
            }

            return error;

        }

        private void AgergarCliente(object sender, EventArgs e)
        {
            try
            {
                con.Abrir();
                string error = verificarCampos();
                string sexo = this.cbSexo.GetItemText(this.cbSexo.SelectedItem);
                if (error == "")
                {
                    con.CargarQuery("INSERT INTO `cliente` (`cedula`, `Nombre`, `Apellido`, `Sexo`, `fechaNacimiento`)" +
                        " VALUES ('"+txtCedula.Text.Trim() + "', '"+txtNombre.Text.Trim() + "', '"+txtApellido.Text.Trim() + "', '"+sexo+
                        "', '"+dtFechaNacimiento.Text+"');");
                    con.GetSalida().Close();
                    MessageBox.Show("Cliente registrado");
                    clearRegistro();
                    CargarClientes();
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

        private void clearRegistro() {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cbSexo.SelectedIndex = -1;
            dtFechaNacimiento.Value = DateTime.Today;
            txtCedula.Focus();
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BuscarPersona(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                string sexo = this.cbSexo.GetItemText(this.cbSexo.SelectedItem);
                con.Abrir();
                con.CargarQuery("select * from cliente where cedula like '" + txtCedula.Text.Trim() +
                    "%' AND nombre like '" + txtNombre.Text.Trim() + "%' AND apellido like '" + txtApellido.Text.Trim() + "%'" +
                    " AND sexo like '" + sexo + "%';");
                DataTable tablaCliente = InicializarTabla();

                IDataReader reader = con.GetSalida();
                DataRow row;
                while (reader.Read())
                {
                    row = tablaCliente.NewRow();
                    row["Cédula"] = reader["cedula"].ToString();
                    row["Nombre"] = reader["nombre"].ToString();
                    row["Apellido"] = reader["apellido"].ToString();
                    row["Sexo"] = reader["sexo"].ToString();
                    row["Edad"] = "Edad";
                    row["Edad"] = CalcularEdad(reader["fechaNacimiento"].ToString());
                    row["Fecha Nacimiento"] = reader["fechaNacimiento"].ToString();
                    tablaCliente.Rows.Add(row);
                }
                dgClientes.Columns.Clear();
                dgClientes.DataSource = tablaCliente;
                dgClientes.Columns["Fecha Nacimiento"].Visible = false;
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

        private string CalcularEdad(string date)
        {
            DateTime birthdate = DateTime.ParseExact(date, "d/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) age--;
            return age.ToString();
        }

        private DataTable InicializarTabla()
        {
            DataTable tablaSalida = new DataTable();
            tablaSalida.Columns.Add(new DataColumn("Cédula"));
            tablaSalida.Columns.Add(new DataColumn("Nombre"));
            tablaSalida.Columns.Add(new DataColumn("Apellido"));
            tablaSalida.Columns.Add(new DataColumn("Sexo"));
            tablaSalida.Columns.Add(new DataColumn("Edad"));
            tablaSalida.Columns.Add(new DataColumn("Fecha nacimiento"));
            return tablaSalida;
        }

        private void LlnearCliente(object sender, DataGridViewCellEventArgs e)
        {
            clearRegistro();

            int rowIndex = dgClientes.CurrentCell.RowIndex;
            txtCedula.Text = dgClientes.Rows[rowIndex].Cells["Cédula"].Value.ToString();
            txtCedula.Text = dgClientes.Rows[rowIndex].Cells["Nombre"].Value.ToString();
            txtCedula.Text = dgClientes.Rows[rowIndex].Cells["Apellido"].Value.ToString();

            string sexo = dgClientes.Rows[rowIndex].Cells["Sexo"].Value.ToString();
            if (sexo == "Masculino") cbSexo.SelectedIndex = 0;
            if (sexo == "Femenino") cbSexo.SelectedIndex = 1;

            string date = dgClientes.Rows[rowIndex].Cells["Fecha Nacimiento"].Value.ToString();
            DateTime birthdate = DateTime.ParseExact(date, "d/MM/yyyy", CultureInfo.InvariantCulture);
            dtFechaNacimiento.Value = birthdate;
        }
    }
}
