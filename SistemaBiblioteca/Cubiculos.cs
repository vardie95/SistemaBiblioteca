﻿using System;
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
        Form1 inicio;
        public Cubículos(Form1 inicio)
        {
            this.inicio = inicio;
            InitializeComponent();
            inicializarFechaActual();
            rbFechaActual.Checked = true;
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.ShowUpDown = true;
            
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");

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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
            dtFecha.SetDate(DateTime.Today);
            dtHora.Enabled = false;
            dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
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
                    string fecha = dtFecha.SelectionEnd.ToString("d/MM/yyyy");
                    con.CargarQuery("INSERT INTO `cubiculo`(`cubiculo`, `fecha`, `horaInicio`, `finalidad`, `beneficiarios`, `encargado`, `cedula`) " +
                        " VALUES ('" + CB_cubiculo.SelectedItem.ToString() + "', '" + fecha + "', '" + dtHora.Text + "', '" + textFinalidad.Text.Trim() +
                        "', '" + CB_beneficiarios.SelectedItem.ToString() + "', '" + CB_encargado.SelectedItem.ToString() + "', '" + TextCedula.Text.Trim() + "');");
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
            textFinalidad.Text = "";
            CB_beneficiarios.SelectedIndex = -1;
            CB_cubiculo.SelectedIndex = -1;
            CB_encargado.SelectedIndex = -1;
        }
        private DataTable InicializarTabla()
        {
            DataTable tablaSalida = new DataTable();
            tablaSalida.Columns.Add(new DataColumn("id"));
            tablaSalida.Columns.Add(new DataColumn("Cédula"));
            tablaSalida.Columns.Add(new DataColumn("Nombre"));
            tablaSalida.Columns.Add(new DataColumn("Apellido"));
            tablaSalida.Columns.Add(new DataColumn("Fecha"));
            tablaSalida.Columns.Add(new DataColumn("Hora Inicio"));
            tablaSalida.Columns.Add(new DataColumn("Hora Fin"));
            tablaSalida.Columns.Add(new DataColumn("Beneficiarios"));
            tablaSalida.Columns.Add(new DataColumn("Cubículo"));
            tablaSalida.Columns.Add(new DataColumn("Finalidad"));
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
                    con.CargarQuery("SELECT cubiculo.id,cubiculo.fecha, cliente.cedula,cliente.Nombre,cliente.Apellido,cubiculo.horaInicio,cubiculo.horaFin" +
                        ",cubiculo.beneficiarios,cubiculo.cubiculo,cubiculo.finalidad, cubiculo.encargado FROM cubiculo,cliente WHERE " +
                        "cliente.cedula=cubiculo.cedula;");
                }
                else
                {
                    con.CargarQuery("SELECT cubiculo.id,cubiculo.fecha, cliente.cedula,cliente.Nombre,cliente.Apellido,cubiculo.horaInicio,cubiculo.horaFin" +
                        ",cubiculo.beneficiarios,cubiculo.cubiculo,cubiculo.finalidad, cubiculo.encargado FROM cubiculo,cliente WHERE " +
                        "cliente.cedula=cubiculo.cedula AND cubiculo.fecha like '%/" + fecha + "';");
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
                    row["Fecha"] = reader["fecha"].ToString();
                    row["Hora Inicio"] = reader["horaInicio"].ToString();
                    row["Hora Fin"] = reader["horaFin"].ToString();
                    row["Beneficiarios"] = reader["beneficiarios"].ToString();
                    row["Cubículo"] = reader["cubiculo"].ToString();
                    row["Finalidad"] = reader["finalidad"].ToString();
                    row["Encargado"] = reader["encargado"].ToString();
                    tablaCliente.Rows.Add(row);
                }
                dgCubiculos.Columns.Clear();
                dgCubiculos.DataSource = tablaCliente;
                dgCubiculos.Columns["id"].Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            if (rbFechaActual.Checked == true)
            {
                dtHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgCubiculos.CurrentCell.RowIndex;
                con.Abrir();
                string id = dgCubiculos.Rows[index].Cells["id"].Value.ToString();
                con.CargarQuery("UPDATE cubiculo SET horaFin= '" + dtHora.Text + "' WHERE cubiculo.id = " + id + ";");
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
                int index = dgCubiculos.CurrentCell.RowIndex;
                con.Abrir();
                string id = dgCubiculos.Rows[index].Cells["id"].Value.ToString();
                con.CargarQuery("DELETE FROM `cubiculo` WHERE id =" + id + "; ");
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
            if (filtrarMes.Text == "Cancelar")
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

        private void Cubículos_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }
    }  


}
