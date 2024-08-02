using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSistemaVentas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtTipo.Text == "" || txtMateriales.Text == "" || txtEstampado.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Nombre = txtNombre.Text,
                    Precio = txtPrecio.Text,
                    Tipo = txtTipo.Text,
                    Materiales = txtMateriales.Text,
                    Estampado = txtEstampado.Text,
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());

                //Escribiendo el archivo Json
                System.IO.File.AppendAllText(@"..\..\docs\02_GuardarProducto.json", json);

                MessageBox.Show("Se han guardado los datos");
            }
            //Limpiar
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Tipo { get; set; }
            public string Materiales { get; set; }
            public string Estampado { get; set; }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
