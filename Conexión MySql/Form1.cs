using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;


namespace ConexionDB
{
    public partial class Form1 : Form
    {
        private DataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            dataAccess = new DataAccess(conexion);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Conexion a MySql.
            string nombre = txtNombre.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);

            try
            {
                dataAccess.InsertProducto(nombre, precio);
                MessageBox.Show("Se han guardado los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
