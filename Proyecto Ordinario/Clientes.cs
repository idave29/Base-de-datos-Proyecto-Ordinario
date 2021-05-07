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
    public partial class Clientes : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        //string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 
        public Clientes()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            //conexion.Open();
        }

        int id = 0;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            id++;
            SqlCommand cmd = new SqlCommand("sp_NombresClientes ", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conexion.Close();
            Limpiar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            conexion.Open();
            id --;
            SqlCommand cmd = new SqlCommand("sp_NombresClientes ", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conexion.Close();
            Limpiar();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Clientes", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            int id = Convert.ToInt16(txtId.Text);
            string cadena = "insert into Clientes values (" + id + ",'"+ txtN.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" + txtC.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Clientes where Id_Cliente=" + txtId.Text, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se borró el artículo");
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
            conexion.Close();
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            int id = Convert.ToInt16(txtId.Text);
            string cadena = "UPDATE Clientes set Id_Cliente='" + id + "',Nombre='" + txtN.Text + "',Ap_Pat='" + txtAP.Text + "',Ap_Mat='" + txtAM.Text + "',Correo='" + txtC.Text + "' WHERE Id_Cliente=" + txtId.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                Limpiar();
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = txtId.Text;
            string cadena = "select * from Clientes where Id_Cliente =" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtId.Text = registro["Id_Cliente"].ToString();
                txtN.Text = registro["Nombre"].ToString();
                txtAP.Text = registro["Ap_Pat"].ToString();
                txtAM.Text = registro["Ap_Mat"].ToString();
                txtC.Text = registro["Correo"].ToString();
            }
            else
                MessageBox.Show("No existe un cliente con el id ingresado");
            conexion.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_NombresClientes ", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conexion.Close();
            Limpiar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PrimerReg()", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtId.Clear();
            txtN.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtC.Clear();
        }

       
    }
}
