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
    public partial class Form3 : Form
    {
        string sexotemp;
        string fechanactemp;
        string situaciontemp;

        public Form3()
        {
            InitializeComponent();
        }
        private void mayusculas(TextBox TB)
        {
            String temp;
            temp = TB.Text;
            TB.Text = temp.ToUpper();
        }

        private void calcularEdad(TextBox Edit, DateTimePicker DTP)
        {
            Edit.Text = (DateTime.Today.AddTicks(-DTP.Value.Ticks).Year - 1).ToString();
        }

        private void limpiar()
        {
            txtCarrera.Text = "";
            cbxSituacion.SelectedItem = 0;
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNombres.Text = "";
            cbxSituacion.SelectedItem = 0;
            txtEdad.Text = "";
            txtCPostal.Text = "";
            txtLNacimiento.Text = "";
            txtNacionalidad.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection cadanaConexionUsu = new SqlConnection("Data Source=LAPTOP-OBEL3V1L; Initial Catalog= ClaseSql; Integrated Security= True");

            if (txtCarrera.Text == "" || cbxSituacion.SelectedIndex < 0 || txtPaterno.Text == "" ||
                txtMaterno.Text == "" || txtNombres.Text == "" || cbxSexo.SelectedIndex < 0 ||
                txtLNacimiento.Text == "" || txtCPostal.Text == "" || txtNacionalidad.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Faltan campo por rellenar");
                cadanaConexionUsu.Close();
            }
            else
            {
                
                //Matriucla duplicada
                String cadenaSqlMatricula = "select * from DatosPersonales where matricula = " + "'" + txtCarrera.Text +"'";


                SqlCommand comando1 = new SqlCommand(cadenaSqlMatricula, cadanaConexionUsu);
                cadanaConexionUsu.Open();
                SqlDataReader lector = comando1.ExecuteReader();
                if (lector.Read() == true)
                {
                    MessageBox.Show("La matricula ya existe");
                    limpiar();
                }
                else
                {

                    SqlConnection cadanaConexion = new SqlConnection("Data Source=LAPTOP-OBEL3V1L; Initial Catalog= ClaseSql; Integrated Security= True");
                    cadanaConexion.Open();
                    if (cbxSexo.SelectedIndex == 0)
                        sexotemp = "M";
                    else if (cbxSexo.SelectedIndex == 1)
                        sexotemp = "F";
                    fechanactemp = dtpFechaNac.Value.Date.ToString("dd/MM/yyy");
                    if (cbxSituacion.SelectedIndex == 0)
                        situaciontemp = "A";
                    else if (cbxSituacion.SelectedIndex == 1)
                        situaciontemp = "B";
                    else if (cbxSituacion.SelectedIndex == 2)
                        situaciontemp = "T";
                    else if (cbxSituacion.SelectedIndex == 3)
                        situaciontemp = "P";

                    mayusculas(txtCarrera);
                    mayusculas(txtPaterno);
                    mayusculas(txtMaterno);
                    mayusculas(txtNombres);
                    mayusculas(txtLNacimiento);
                    mayusculas(txtNacionalidad);

                   
                    String cadenaSql = "Insert into DatosPersonales" +
                        "(Matricula, situacion, Paterno, Materno, Nombres, Sexo, FechaNacimiento," +
                        "Lnacimiento, CP, Nacionalidad)" +
                        "Values ('" + txtCarrera.Text + "','" + situaciontemp + "','" + txtPaterno.Text + "','" +
                        txtMaterno.Text + "','" + txtNombres.Text + "','" +
                        sexotemp + "','" + fechanactemp + "','" + txtLNacimiento.Text + "','" +
                        txtCPostal.Text + "','" + txtNacionalidad.Text + "')";

                    SqlCommand comando = new SqlCommand(cadenaSql, cadanaConexion);
                    comando.ExecuteNonQuery();
                    cadanaConexion.Close();
                    MessageBox.Show("El registro se realizo con exito", "Registro realizado");
                    limpiar();
                    this.Close();
                }

                cadanaConexionUsu.Close();


                //Fin matricula duplicada
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            calcularEdad(txtEdad,dtpFechaNac);
        }
    }
}
