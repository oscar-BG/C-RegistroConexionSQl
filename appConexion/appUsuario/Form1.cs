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

namespace appUsuario
{
    public partial class Form1 : Form
    {
        FBienvenido f2 = new FBienvenido();
        SqlConnection cadenaConexion = new SqlConnection("Data Source=LAPTOP-OBEL3V1L;Initial Catalog=Sabatino;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String cadenaSql = "select * from usuarios where nombreUsuario = " + "'" + txtUsuario.Text + "' and clave = " + "'" + txtPassword.Text + "'";

            SqlCommand comando = new  SqlCommand(cadenaSql, cadenaConexion);
            cadenaConexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read() == true)
            {
                this.Hide();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o Password incorrecto");
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }

            cadenaConexion.Close();
        }
    }
}
