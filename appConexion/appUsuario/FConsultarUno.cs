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
    public partial class FConsultarUno : Form
    {
        SqlConnection cadenaConexion = new SqlConnection("Data Source=LAPTOP-OBEL3V1L; Initial Catalog= ClaseSql; Integrated Security= True");
        public FConsultarUno()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            txtMatricula.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            txtSexo.Clear();
            txtLNacimiento.Clear();
            txtCPostal.Clear();
            txtNacionalidad.Clear();
            txtFechanac.Clear();
            txtEdad.Clear();
            txtMatricula.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cadenaSql = "Select * from DatosPersonales where matricula =" + "'" + txtMatricula.Text + "'";
            SqlCommand comando = new SqlCommand(cadenaSql, cadenaConexion);
            cadenaConexion.Open();
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read() == true)
            {
                txtPaterno.Text = lector["Paterno"].ToString();
                txtMaterno.Text = lector["Materno"].ToString();
                txtNombres.Text = lector["Nombres"].ToString();
                txtSexo.Text = lector["Sexo"].ToString();
                txtLNacimiento.Text = lector["Lnacimiento"].ToString();
                txtCPostal.Text = lector["cp"].ToString();
                txtNacionalidad.Text = lector["Nacionalidad"].ToString();
                txtFechanac.Text = lector["FechaNacimiento"].ToString();
            }
            else
            {
                MessageBox.Show("Matricula no existe");
                limpiar();
            }
            cadenaConexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
