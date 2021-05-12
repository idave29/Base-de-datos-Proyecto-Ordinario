using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_Ordinario
{
    public partial class Compra : Form
    {
        //Conexion a la base de datos
        SqlConnection conexion = new SqlConnection();
        string cadena = "Data Source=PC-DAVID;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=shamiko;Initial Catalog=TiendaTec;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-445GP77;Initial Catalog=TiendaTec;Integrated Security=True";
        int id = 0;
        double subTotal = 0.0;
        double costoProd = 0.0;
        double total = 0.0;
        double IVAPedido = 0.0;

        public Compra()
        {
            InitializeComponent();
            conexion.ConnectionString = cadena;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet5.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.tiendaTecDataSet5.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet4.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tiendaTecDataSet4.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet3.Sucursales' Puede moverla o quitarla según sea necesario.
            this.sucursalesTableAdapter.Fill(this.tiendaTecDataSet3.Sucursales);
            // TODO: esta línea de código carga datos en la tabla 'tiendaTecDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.tiendaTecDataSet.Productos);
        }

        private void iconMostrar_Click(object sender, EventArgs e)
        {
            double IVA = Convert.ToDouble(txtIva.Text);
            total = subTotal;
            if (IVAPedido == IVA)
                IVA = 0;
            if (IVA < IVAPedido)
                IVA = IVA * -1;

            total = total + ((IVA / 100) * subTotal);
            lbTotalFinal.Text = total.ToString();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (rdbProd.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM sw_ProductosTicket", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            if (rdbTicket.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Ticket", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //conexion.Open();
            if (rdbProd.Checked == true)
            {
                if (txtId.Text != "" && txtCantidad.Text != "" && cmbProd.Text != "")
                {
                    conexion.Open();
                    int id = Convert.ToInt16(txtId.Text);

                    //subTotal = 0.0;
                    int prod = Convert.ToInt16(cmbProd.SelectedIndex) + 1;
                    int cant = Convert.ToInt16(txtCantidad.Text);

                    string cadena0 = "select Precio from Productos where Id_Producto =" + prod;
                    SqlCommand comando0 = new SqlCommand(cadena0, conexion);
                    costoProd = Convert.ToDouble(comando0.ExecuteScalar());
                    subTotal = subTotal + (costoProd * cant);
                    lbSubtotal.Text = subTotal.ToString();

                    string cadena = "insert into Productos_Ticket values (" + prod + "," + id + "," + txtCantidad.Text + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El producto se agrego correctamente");

                }
                else
                    MessageBox.Show("Llenar los campos");

            }
            if (rdbTicket.Checked == true)
            {
                if (txtId.Text != "" && txtIva.Text != "")
                {
                    //////////////////////////////////////
                    conexion.Close();
                    if (ExisteRegistro())
                    {
                        conexion.Open();
                        double IVA = Convert.ToDouble(txtIva.Text);
                        total = subTotal;
                        total = total + ((IVA / 100) * subTotal);
                        //lbTotalFinal.Text = total.ToString();
                        string cadena1 = "insert into Ticket values (" + txtId.Text + ",'" + dateTimePicker1.Value.ToShortDateString() + "'," + (cmbSucursal.SelectedIndex + 1) + "," + total + "," + IVA + "," + (cmbCliente.SelectedIndex + 1) + "," + (cmbEmpleado.SelectedIndex + 1) + ")";
                        SqlCommand comando1 = new SqlCommand(cadena1, conexion);
                        comando1.ExecuteNonQuery();
                        MessageBox.Show("Los datos del ticket se guardaron correctamente");
                        lbTotalFinal.Text = "--";
                        lbSubtotal.Text = "--";
                    }
                }
                else
                    MessageBox.Show("Llenar los campos");
            }
            Limpiar();
            conexion.Close();
        }

        private bool ExisteRegistro()
        {
            conexion.Open();
            string cod = txtId.Text;
            string cadena = "sp_Ticket";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", cod);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("ya existe el Folio");
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
                if (rdbProd.Checked == true)
                {
                    //int cant1 = Convert.ToInt16(txtCantidad.Text);
                    SqlCommand comando = new SqlCommand("delete from Productos_Ticket where Folio_Ticket=" + txtId.Text, conexion);
                    int cant;
                    cant = comando.ExecuteNonQuery();
                    if (cant >= 1)
                    {
                        string cadena0 = "select Precio from Productos where Id_Producto =" + txtId.Text;
                        SqlCommand comando0 = new SqlCommand(cadena0, conexion);
                        costoProd = Convert.ToDouble(comando0.ExecuteScalar());
                        if (subTotal <= 0)
                            lbSubtotal.Text = subTotal.ToString();
                        else
                        {
                            subTotal = subTotal - (costoProd * cant);
                            lbSubtotal.Text = subTotal.ToString();
                        }
                        MessageBox.Show("Se borró el producto");
                    }
                    else
                    {
                        MessageBox.Show("No existe el producto con el Folio del Ticket");
                    }
                }
                if (rdbTicket.Checked == true)
                {
                    SqlCommand comando = new SqlCommand("delete from Ticket where Folio_Ticket=" + txtId.Text, conexion);
                    int cant, cant2;
                    cant = comando.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        SqlCommand comando1 = new SqlCommand("delete from Productos_Ticket where Folio_Ticket=" + txtId.Text, conexion);
                        cant2 = comando1.ExecuteNonQuery();
                        MessageBox.Show("Se borró el ticket");
                    }
                    else
                    {
                        MessageBox.Show("No existe el Folio del Ticket");
                    }
                }
            }
            else
                MessageBox.Show("No dejar vacio el Folio Ticket");
            lbTotalFinal.Text = "--";
            conexion.Close();
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            if (rdbProd.Checked == true)
            {
                if (txtId.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("sp_PT", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    conexion.Close();
                    Limpiar();
                }
                else
                    MessageBox.Show("No dejar vacio el Folio_Ticket");
            }
            if (rdbTicket.Checked == true)
            {
                if (txtId.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("sp_Ticket", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    conexion.Close();
                    Limpiar();
                }
                else
                    MessageBox.Show("No dejar vacio el Folio_Ticket");
            }
            conexion.Close();
        }

        private void btnCrearT_Click(object sender, EventArgs e)
        {
            conexion.Open();
            double suma = 0.0;
            SqlCommand cmd = new SqlCommand("sp_TotalProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null) //1 es "Cantidad"
                    suma += Convert.ToDouble(row.Cells[5].Value);
            }
            subTotal = suma;
            lbSubtotal.Text = suma.ToString();
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //cmbCliente.Enabled = false;
            conexion.Open();
            if (txtId.Text != "")
            {
                string cod = txtId.Text;
                string cadena = "sp_Ticket";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", cod);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtId.Text = registro["Folio_Ticket"].ToString();
                    dateTimePicker1.Text = registro["Fecha_Hora_Venta"].ToString();
                    cmbSucursal.Text = registro["Nombre_Sucursal"].ToString();
                    txtIva.Text = registro["IVA"].ToString();
                    cmbCliente.Text = registro["Correo"].ToString();
                    cmbEmpleado.Text = registro["CorreoE"].ToString();
                    lbTotalFinal.Text = registro["Total"].ToString();
                    subTotal = Convert.ToDouble(registro["Total"].ToString());
                    IVAPedido = Convert.ToDouble(registro["IVA"].ToString());
                }
                else
                    MessageBox.Show("No existe el empleado con el id ingresado");
            }
            else
                MessageBox.Show("No dejar vacio el ID");
            conexion.Close();
            //cmbCliente.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtId.Text != "" && txtIva.Text != "")
            {
                int surc = Convert.ToInt16(cmbSucursal.SelectedIndex) + 1;
                int cliente = Convert.ToInt16(cmbCliente.SelectedIndex) + 1;
                int empl = Convert.ToInt16(cmbEmpleado.SelectedIndex) + 1;
                int id = Convert.ToInt16(txtId.Text);
                string cadena = "UPDATE Ticket set Folio_Ticket='" + id + "',Fecha_Hora_Venta='" + dateTimePicker1.Value.ToShortDateString() + "',Id_Sucursal='" + surc + "',Total='" + lbTotalFinal.Text + "',IVA='" + txtIva.Text + "',Id_Cliente='" + cliente + "',Id_Empleado=" + empl + "WHERE Folio_Ticket=" + txtId.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del ticket");
                    Limpiar();
                }
                else
                    MessageBox.Show("No existe el ticket con el código ingresado");
            }
            else
                MessageBox.Show("Lllenar los campos");
            conexion.Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (rdbProd.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PrimerRegProdT()", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            if (rdbTicket.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM  PrimerRegTicket()", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            conexion.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (rdbProd.Checked == true)
            {
                id--;
                SqlCommand cmd = new SqlCommand("sp_PT", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            if (rdbTicket.Checked == true)
            {
                id--;
                SqlCommand cmd = new SqlCommand("sp_Ticket", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            conexion.Close();
            Limpiar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (rdbProd.Checked == true)
            {
                id++;
                SqlCommand cmd = new SqlCommand("sp_PT", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            if (rdbTicket.Checked == true)
            {
                id++;
                SqlCommand cmd = new SqlCommand("sp_Ticket", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            conexion.Close();
            Limpiar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (rdbProd.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM UltimoRegProdT()", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            if (rdbTicket.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM UltimoRegT()", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            conexion.Close();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtCantidad.Clear();
            txtIva.Clear();
            lbTotalFinal.Text = "--";
            lbSubtotal.Text = "--";
        }

        
    }
}
