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

        Conexion con;
        public Estadisticas()
        {
            con = new Conexion(@"Data Source = localhost;port=3306;Initial"
            + " Catalog=sistemabiblioteca;User Id=root;password = '' ");

            InitializeComponent();
            SetMyCustomFormat();

            dgEstadistica.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgEstadistica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void cbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            fechaEstadistica.Format = DateTimePickerFormat.Custom;
            fechaEstadistica.CustomFormat = "MM/yyyy";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void fechaEstadistica_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcSelecc_Click(object sender, EventArgs e)
        {
            if(cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Computadora")
            {
                calcularComputadora(cbEstadistica.GetItemText(cbEstadistica.SelectedItem));
            }
            if (cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Cubículo")
            {
                calcularCubiculo(cbEstadistica.GetItemText(cbEstadistica.SelectedItem));
            }
            if (cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Libro")
            {
                calcularLibro(cbEstadistica.GetItemText(cbEstadistica.SelectedItem));
            }
        }

        private void calcularComputadora(string estadistica)
        {
            if(estadistica == "Cantidad" || estadistica == "")
            {
                calcularCantidadPrestamos("Computdora","computadoras","fecha");
            }
            if (estadistica == "Género" || estadistica == "")
            {
                calcularCantidadSexo("Computdora", "computadoras", "fecha");
            }
            if (estadistica == "Grupo de edad" || estadistica == "")
            {
                calcularGrupoEdad("Computdora", "computadoras", "fecha");
            }

        }

        private void calcularCubiculo(string estadistica)
        {
            if (estadistica == "Cantidad" || estadistica == "")
            {
                calcularCantidadPrestamos("Cubículo", "cubiculo","fecha");
            }
            if (estadistica == "Género" || estadistica == "")
            {
                calcularCantidadSexo("Cubículo", "cubiculo", "fecha");
            }
            if (estadistica == "Grupo de edad" || estadistica == "")
            {
                calcularGrupoEdad("Cubículo", "cubiculo", "fecha");
            }
        }


        private void calcularLibro(string estadistica)
        {
            if (estadistica == "Cantidad" || estadistica == "")
            {
                calcularCantidadPrestamos("Libro","libro", "fechaPrestamo");
            }
            if (estadistica == "Género" || estadistica == "")
            {
                calcularCantidadSexo("Libro", "libro", "fechaPrestamo");
            }
            if (estadistica == "Grupo de edad" || estadistica == "")
            {
                calcularGrupoEdad("Libro", "libro", "fechaPrestamo");
            }
        }
       

        private void calcularCantidadPrestamos(string nombre,string tabla,string fecha)
        {
            try
            {
                con.Abrir();
                con.CargarQuery("SELECT count(*) FROM " + tabla + " WHERE "+ fecha + " like '%/"+ 
                    fechaEstadistica.Text+ "';");
                
                IDataReader reader = con.GetSalida();
                DataGridViewRow row = (DataGridViewRow)dgEstadistica.Rows[0].Clone();

                while (reader.Read())
                {
                    row.Cells[0].Value = ""+nombre+"/Cantidad";
                    row.Cells[1].Value = fechaEstadistica.Text;
                    row.Cells[2].Value = reader["count(*)"].ToString();
                    dgEstadistica.Rows.Add(row);
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

        private void calcularCantidadSexo(string nombre, string tabla, string fecha)
        {
            try
            {
                con.Abrir();
                string fechaBusqueda = tabla + "." + fecha;
                con.CargarQuery("SELECT count(*),cliente.Sexo FROM " + tabla + ",cliente" +
                    " WHERE " + fechaBusqueda + " like '%/"+fechaEstadistica.Text + "' AND cliente.cedula = "+tabla+".cedula" +
                    " GROUP BY cliente.Sexo; ");
                IDataReader reader = con.GetSalida();
                string resultado="";

                while (reader.Read())
                {
                    resultado += reader["Sexo"].ToString()+ ":" +reader["count(*)"].ToString()+ " ";
                }
                DataGridViewRow row = (DataGridViewRow)dgEstadistica.Rows[0].Clone();
                row.Cells[0].Value = "" + nombre + "/Género";
                row.Cells[1].Value = fechaEstadistica.Text;
                row.Cells[2].Value = resultado;
                dgEstadistica.Rows.Add(row);
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

        private void calcularGrupoEdad(string nombre, string tabla, string fecha)
        {
            try
            {
                con.Abrir();
                string fechaBusqueda = tabla + "." + fecha;

                con.CargarQuery("SELECT "+
                    "SUM(IF(persona.age < 20, 1, 0)) as 'Menor a 20',"+
                    "SUM(IF(persona.age BETWEEN 20 and 29, 1, 0)) as '20 - 29',"+
                    "SUM(IF(persona.age BETWEEN 30 and 39, 1, 0)) as '30 - 39',"+
                    "SUM(IF(persona.age BETWEEN 40 and 49, 1, 0)) as '40 - 49',"+
                    "SUM(IF(persona.age BETWEEN 50 and 59, 1, 0)) as '50 - 59',"+
                    "SUM(IF(persona.age > 60, 1, 0)) as 'mayor a 60'"+

                    "FROM(SELECT EXTRACT(YEAR FROM(FROM_DAYS(DATEDIFF(NOW(), STR_TO_DATE(cliente.fechaNacimiento,'%d/%m/%Y')))))" +
                    " + 0 age, cedula from cliente) AS persona, "+tabla+" WHERE "+tabla+".cedula = persona.cedula AND "+
                    ""+ fechaBusqueda + " like '%/" + fechaEstadistica.Text + "'; ");
                IDataReader reader = con.GetSalida();
                string resultado = "";
                string nl = Environment.NewLine;
                while (reader.Read())
                {
                    resultado+="Menor a 20: " + reader[0].ToString() + nl;
                    resultado += "20-29: " + reader[1].ToString() + nl;
                    resultado += "30-39: " + reader[2].ToString() + nl;
                    resultado += "40-49: " + reader[3].ToString() + nl;
                    resultado += "50-59: " + reader[4].ToString() + nl;
                    resultado += "Mayor a 60: " + reader[5].ToString();
                }
                DataGridViewRow row = (DataGridViewRow)dgEstadistica.Rows[0].Clone();
                row.Cells[0].Value = "" + nombre + "/Edad";
                row.Cells[1].Value = fechaEstadistica.Text;
                row.Cells[2].Value = resultado;
                dgEstadistica.Rows.Add(row);
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



        private void btnCalcTodas_Click(object sender, EventArgs e)
        {
            if (cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Computadora")
            {
                calcularComputadora("");
            }
            if (cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Cubículo")
            {
                calcularCubiculo("");
            }
            if (cbTipoPrestamo.GetItemText(cbTipoPrestamo.SelectedItem) == "Libro")
            {
                calcularLibro("");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgEstadistica.Rows.Clear();
        }

    }
}
