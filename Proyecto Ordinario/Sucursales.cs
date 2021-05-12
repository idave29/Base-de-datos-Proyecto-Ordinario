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
    public partial class Sucursales : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True";
        int id = 0;

        public Sucursales()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtCalle.Text != "" && txtColonia.Text != "" && txtNumero.Text != "")
            {
                conexion.Close();
                if (ExisteRegistro())
                {
                    conexion.Open();
                    int id = Convert.ToInt16(txtId.Text);
                    int num = Convert.ToInt16(txtNumero.Text);
                    string cadena = "insert into Sucursales values (" + id + ",'" + txtN.Text + "','" + txtCalle.Text + "'," + num + ",'" + txtColonia.Text + "')";
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
            string cadena = "sp_Prov";
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

        private void Limpiar()
        {
            txtId.Clear();
            txtN.Clear();
            txtNumero.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand comando = new SqlCommand("delete from Sucursales where Id_Sucursal=" + txtId.Text, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se borró la sucursal");
                }
                else
                {
                    MessageBox.Show("No existe la sucursal con el ID ingresado");
                }
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                string cod = txtId.Text;
                string cadena = "select * from Sucursales where Id_Sucursal =" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtId.Text = registro["Id_Sucursal"].ToString();
                    txtN.Text = registro["Nombre_Sucursal"].ToString();
                    txtCalle.Text = registro["Calle"].ToString();
                    txtNumero.Text = registro["Numero"].ToString();
                    txtColonia.Text = registro["Colonia"].ToString();
                }
                else
                    MessageBox.Show("No existe la sucursal con el id ingresado");
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtCalle.Text != "" && txtColonia.Text != "" && txtNumero.Text != "")
            {
                int id = Convert.ToInt16(txtId.Text);
                int num = Convert.ToInt16(txtNumero.Text);
                string cadena = "UPDATE Sucursales set Id_Sucursal=" + id + ",Nombre_Sucursal='" + txtN.Text + "',Calle='" + txtCalle.Text + "',Numero='" + num + "',Colonia='" + txtColonia.Text + "' WHERE Id_Sucursal=" + txtId.Text;
                //string cadena = "UPDATE Sucursales set Id_Cliente='" + id + "',Nombre='" + txtN.Text + "',Ap_Pat='" + txtAP.Text + "',Ap_Mat='" + txtAM.Text + "',Correo='" + txtC.Text + "' WHERE Id_Cliente=" + txtId.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos de la sucursal");
                    Limpiar();
                }
                else
                    MessageBox.Show("No existe una sucursal con el ID ingresado");
            }
            else
                MessageBox.Show("Llenar los campos");
            conexion.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_Prov", conexion);
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Sucursales", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * From PrimerRegS()", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            conexion.Open();
            id--;
            SqlCommand cmd = new SqlCommand("sp_Prov", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conexion.Close();
            Limpiar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            id++;
            SqlCommand cmd = new SqlCommand("sp_Prov", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conexion.Close();
            Limpiar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Sucursales ORDER BY Id_Sucursal DESC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
