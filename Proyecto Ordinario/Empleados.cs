using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ordinario
{
    public partial class Empleados : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 

        public Empleados()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            //conexion.Open();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Empleados", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd; 
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla; 
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet2.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.tiendaTecDataSet2.Puestos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtC.Text != "" && txtContra.Text != "" && txtSueldo.Text != "")
            {
                int puesto = Convert.ToInt16(comboBox1.SelectedIndex) + 1;
                int id = Convert.ToInt16(txtId.Text);
                string cadena = "insert into Empleados values (" + id + ",'" + txtN.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" + txtC.Text + "','" + txtSueldo.Text + "','" + puesto + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + txtContra.Text + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                Limpiar();
            }
            else
                MessageBox.Show("Lllenar los campos");
            conexion.Close();

        }

        private void Limpiar()
        {
            txtId.Clear();
            txtN.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtC.Clear();
            txtContra.Clear();
            txtSueldo.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        //private void btnCalendar_Click(object sender, EventArgs e)
        //{
        //    DateTime date = new DateTime();
        //    date.ToShortDateString();
        //    dateTimePicker1.CustomFormat = 
        //    try
        //    {
        //        monthCalendar1.Visible = true;
        //    }
        //    catch
        //    {
        //        monthCalendar1.Visible = false; 
        //    }
        //}
    }
}
