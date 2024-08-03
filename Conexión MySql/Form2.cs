using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace ConexionDB
{
    public partial class Form2 : Form
    {
        private DataAccess dataAccessConsultas;

        public Form2()
        {
            InitializeComponent();
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            dataAccessConsultas = new DataAccess(conexion);
            CargarDatosComboBox();
        }

        private void CargarDatosComboBox()
        {
            try
            {
                DataTable dataTable = dataAccessConsultas.GetData();
                cBoxArticulos.DataSource = dataTable;
                cBoxArticulos.DisplayMember = "nombre";
                cBoxArticulos.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
