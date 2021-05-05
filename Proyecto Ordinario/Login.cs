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
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True"; 
        public Login()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
            conexion.Open();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id_Empleado, Contrasenia FROM Empleados WHERE Id_Empleado='"+txtUsuario.Text+ 
                "' AND Contrasenia='"+txtPass.Text+"'", conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login exitoso");
            }
            else
            {
                MessageBox.Show("Login fallido");
                dr.Close(); 
            }
        }
    }
}
