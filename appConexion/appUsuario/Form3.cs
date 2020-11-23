using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lblEdad.Text = "";
            txtCPostal.Text = "";
            txtLNacimiento.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
