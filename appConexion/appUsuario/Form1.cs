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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtUsuario.Text != "")
            {
                if (txtPassword.Text == "Hola" && txtUsuario.Text == "Hol@")
                {
                    FBienvenido f2 = new FBienvenido();
                    this.Hide();
                    f2.ShowDialog();
                }
            }
        }
    }
}
