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
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 
        int id = 0;

        public Clientes()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            //conexion.Open();
        }

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
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Clientes", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtC.Text != "")
            {
                conexion.Close();
                if (ExisteRegistro())
                {
                    conexion.Open();
                    int id = Convert.ToInt16(txtId.Text);
                    string cadena = "insert into Clientes values (" + id + ",'" + txtN.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" + txtC.Text + "')";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente");
                    Limpiar();
                }
            }
            else
                MessageBox.Show("Lllenar los campos");
            conexion.Close();
        }

        private bool ExisteRegistro()
        {
            conexion.Open();
            string cod = txtId.Text;
            string cadena = "sp_NombresClientes";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", cod);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("Ya existe el ID");
                return false;
            }
            else
                conexion.Close();
            return true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand comando = new SqlCommand("delete from Clientes where Id_Cliente=" + txtId.Text, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se borró el cliente");
                }
                else
                {
                    MessageBox.Show("No existe un cliente con el ID ingresado");
                }
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtC.Text != "")
            {
                int id = Convert.ToInt16(txtId.Text);
                string cadena = "UPDATE Clientes set Id_Cliente='" + id + "',Nombre='" + txtN.Text + "',Ap_Pat='" + txtAP.Text + "',Ap_Mat='" + txtAM.Text + "',Correo='" + txtC.Text + "' WHERE Id_Cliente=" + txtId.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del cliente");
                    Limpiar();
                }
                else
                    MessageBox.Show("No existe un cliente con el ID ingresado");
            }
            else
                MessageBox.Show("Lllenar los campos");
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
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
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_NombresClientes ", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                conexion.Close();
                Limpiar();
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
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
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Clientes ORDER BY Id_Cliente DESC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
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
