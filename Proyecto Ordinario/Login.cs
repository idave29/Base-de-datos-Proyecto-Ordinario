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
    public partial class Login : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        //string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 
        public Login()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            conexion.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Logear(txtUsuario.Text, txtPass.Text);
        }

        public void Logear(string pUsuario, string pContra)
        {
            conexion.Open();

            //SqlCommand cmd = new SqlCommand("SELECT Correo, Contrasenia, id_Puesto FROM Empleados WHERE Correo='" + txtUsuario.Text +
            //        "' AND Contrasenia='" + txtPass.Text + "'", conexion);

            //SqlDataReader lector = cmd.ExecuteReader();

            //lector.Read();

            //int rol = Convert.ToInt(lector.GetValue())


            SqlCommand cmd = new SqlCommand("SELECT E.Correo, E.Contrasenia, P.Descripcion FROM Empleados E, Puestos P WHERE E.Id_Puesto = P.Id_Puesto AND Correo='" + txtUsuario.Text  +
                "' AND Contrasenia='" + txtPass.Text + "'", conexion);
            cmd.Parameters.AddWithValue("Correo", txtUsuario.Text);
            cmd.Parameters.AddWithValue("Contrasenia", txtPass.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //SqlDataReader dr = cmd.ExecuteReader();
                
                

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                //MessageBox.Show("Login exitoso");
                if (dt.Rows[0][2].ToString() == "Administrador")
                {
                    new Menu_Principal().Show();
                    //menu.Show();
                }
                else if (dt.Rows[0][2].ToString() == "Cajero")
                {
                    Menu_Cajero menug = new Menu_Cajero();
                    menug.Show();
                }
                else if (dt.Rows[0][2].ToString() == "Gerente de Ventas")
                {
                    Menu_Gerente menug = new Menu_Gerente();
                    menug.Show();
                }

            }
            else
            {
                MessageBox.Show("Login fallido");
            }
            conexion.Close();
        }
    }
}
