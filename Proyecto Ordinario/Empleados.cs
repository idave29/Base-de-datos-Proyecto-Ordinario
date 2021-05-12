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
        int id = 0;

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
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet6.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.tiendaTecDataSet6.Puestos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtC.Text != "" && txtContra.Text != "" && txtSueldo.Text != "")
            {
                conexion.Close();
                if (ExisteRegistro())
                {
                    conexion.Open();
                    int puesto = Convert.ToInt16(cmbPuesto.SelectedIndex) + 1;
                    int id = Convert.ToInt16(txtId.Text);
                    string cadena = "insert into Empleados values (" + id + ",'" + txtN.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" + txtC.Text + "','" + txtSueldo.Text + "','" + puesto + "','" + dateTimePicker1.Value.Date.ToString("MM-dd-yyyy") + "','" + txtContra.Text + "')";
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
            string cadena = "sp_NombreEmpleado";
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
            txtAP.Clear();
            txtAM.Clear();
            txtC.Clear();
            txtContra.Clear();
            txtSueldo.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "")
            {
                SqlCommand comando = new SqlCommand("delete from Empleados where Id_Empleado=" + txtId.Text, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se borró el empleado");
                }
                else
                {
                    MessageBox.Show("No existe un empleado con el ID ingresado");
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
                string cadena = "sp_NombreEmpleado";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", cod);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtId.Text = registro["ID"].ToString();
                    txtN.Text = registro["Nombre"].ToString();
                    txtAP.Text = registro["Apellido Paterno"].ToString();
                    txtAM.Text = registro["Apellido Materno"].ToString();
                    txtC.Text = registro["Correo"].ToString();
                    txtSueldo.Text = registro["Sueldo"].ToString();
                    cmbPuesto.Text = registro["Puesto"].ToString();
                    dateTimePicker1.Text = registro["Fecha_Nacimiento"].ToString();
                    txtContra.Text = registro["Contraseña"].ToString();

                    //txtId.Text = registro["Id_Empleado"].ToString();
                    //txtN.Text = registro["Nombre"].ToString();
                    //txtAP.Text = registro["Ap_Pat"].ToString();
                    //txtAM.Text = registro["Ap_Mat"].ToString();
                    //txtC.Text = registro["Correo"].ToString();
                    //txtSueldo.Text = registro["Sueldo"].ToString();
                    //cmbPuesto.Text = registro["Descripcion"].ToString();
                    //dateTimePicker1.Text = registro["Fecha_Nacimiento"].ToString();
                    //txtContra.Text = registro["Contrasenia"].ToString();

                }
                else
                    MessageBox.Show("No existe el empleado con el id ingresado");
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtN.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtC.Text != "" && txtContra.Text != "" && txtSueldo.Text != "")
            {
                int puesto = Convert.ToInt16(cmbPuesto.SelectedIndex) + 1;
                int id = Convert.ToInt16(txtId.Text);
                string cadena = "UPDATE Empleados set Id_Empleado='" + id + "',Nombre='" + txtN.Text + "',Ap_Pat='" + txtAP.Text + "',Ap_Mat='" + txtAM.Text + "',Correo='" + txtC.Text + "',Sueldo='" + txtSueldo.Text + "',Id_Puesto='" + puesto + "',Fecha_Nacimiento='" + dateTimePicker1.Value.Date.ToString("MM-dd-yyyy") + "',Contrasenia='" + txtContra.Text + "' WHERE Id_Empleado=" + id;
                //string cadena = "UPDATE Productos set Id_Producto='" + id + "',Producto='" + txtN.Text + "',Descripcion='" + txtDesc.Text + "',Precio='" + txtPrecio.Text + "',Marca='" + marca + "',Categoria='" + categoria + "' WHERE Id_Producto=" + txtId.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del empleado");
                    Limpiar();
                }
                else
                    MessageBox.Show("No existe el empleado con el código ingresado");
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
                SqlCommand cmd = new SqlCommand("sp_NombreEmpleado", conexion);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM PrimerRegEmp()", conexion);
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
            SqlCommand cmd = new SqlCommand("sp_NombreEmpleado", conexion);
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
            SqlCommand cmd = new SqlCommand("sp_NombreEmpleado", conexion);
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
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Empleados ORDER BY Id_Empleado DESC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
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
