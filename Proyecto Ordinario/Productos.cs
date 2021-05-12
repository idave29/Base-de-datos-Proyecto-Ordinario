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
    public partial class Productos : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 
        int id = 0;

        public Productos()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            //conexion.Open();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Productos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet8.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.tiendaTecDataSet8.Categorias);
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet7.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.tiendaTecDataSet7.Marcas);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtDesc.Text != "" && txtPrecio.Text != "")
            {
                conexion.Close();
                if (ExisteRegistro())
                {
                    conexion.Open();
                    int marca = Convert.ToInt16(cmbMarca.SelectedIndex) + 1;
                    int categoria = Convert.ToInt16(cmbCateg.SelectedIndex) + 1;
                    int id = Convert.ToInt16(txtId.Text);
                    string cadena = "insert into Productos values (" + id + ",'" + txtN.Text + "','" + txtDesc.Text + "','" + txtPrecio.Text + "','" + marca + "','" + categoria + "')";
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
            string cadena = "sp_IDProducto";
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
            txtDesc.Clear();
            txtPrecio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand comando = new SqlCommand("delete from Productos where Id_Producto=" + txtId.Text, conexion);
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
                int cod = Convert.ToInt16(txtId.Text);
                //string cadena = "select Id_Producto, Producto, Descripcion, Precio, Marca, Categoria from Productos P, Marcas M, Categorias C where Id_Producto ="+cod+" AND P.Id_Marca = M.Id_Marca and P.Id_Categoria = C.Id_Categoria";
                string cadena = "sp_IDProducto";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", cod);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtId.Text = registro["Id_Producto"].ToString();
                    txtN.Text = registro["Producto"].ToString();
                    txtDesc.Text = registro["Descripcion"].ToString();
                    txtPrecio.Text = registro["Precio"].ToString();
                    cmbMarca.Text = registro["Marca"].ToString();
                    cmbCateg.Text = registro["Categoria"].ToString();
                }
                else
                    MessageBox.Show("No existe un producto con el id ingresado");
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtDesc.Text != "" && txtPrecio.Text != "")
            {
                int marca = Convert.ToInt16(cmbMarca.SelectedIndex) + 1;
                int categoria = Convert.ToInt16(cmbCateg.SelectedIndex) + 1;
                int id = Convert.ToInt16(txtId.Text);
                string cadena = "UPDATE Productos set Id_Producto='" + id + "',Producto='" + txtN.Text + "',Descripcion='" + txtDesc.Text + "',Precio='" + txtPrecio.Text + "',Id_Marca='" + marca + "',Id_Categoria='" + categoria + "' WHERE Id_Producto=" + txtId.Text;
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
            }
            else
                MessageBox.Show("Lllenar los campos");
            conexion.Close();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_IDProducto", conexion);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM PrimerRegProd()", conexion);
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
            SqlCommand cmd = new SqlCommand("sp_IDProducto", conexion);
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
            SqlCommand cmd = new SqlCommand("sp_IDProducto", conexion);
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
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Productos ORDER BY Id_Producto DESC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();

        }
    }
}
