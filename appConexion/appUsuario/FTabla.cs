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
    public partial class FTabla : Form
    {
        public FTabla()
        {
            InitializeComponent();
        }

        private void FTabla_Load(object sender, EventArgs e)
        {
            //Enlazar el DataGridView al bindinSource1 y cargar los datos de la base de datos
            dgvTablaRegistros.DataSource = bindingSource1;
            obtenerDatos("select * from DatosPersonales");
        }

        private void obtenerDatos(string comandoSelect)
        {
            try
            {
                //Especificar la cadena de conexion
                String cadenaConexion = "Integrated Security= SSPI; Persist Security Info=False;" +
                    "Initial Catalog=ClaseSql; Data Source=LAPTOP-OBEL3V1L";
                //Crear un nuevo adaptador de datos basado en la consulta especifica;
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(comandoSelect, cadenaConexion);

                //llamar a una nueva tabla de datos y enlazarlo a bindingSource

                DataTable tabla = new DataTable();
                adaptadorDatos.Fill(tabla);
                bindingSource1.DataSource = tabla;

                //Cambiar el tamañ de las columnas DataGridView para adaptarse al contenido recién cargada.
                dgvTablaRegistros.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch(SqlException)
            {
                MessageBox.Show("Para ejecutar este ejemplo, sustituir el valor de la variable de cadena de conexion" +
                    "con una cadena de conexion que es valida para el sistema.", "Soluciones");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
