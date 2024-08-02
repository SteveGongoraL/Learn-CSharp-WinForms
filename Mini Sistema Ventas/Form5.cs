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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        //Validar Campos
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" || txtTipo.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Tipo = txtTipo.Text,
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());

                //Escribiendo el archivo Json
                System.IO.File.AppendAllText(@"..\..\docs\03_GuardarProveedores.json", json);

                MessageBox.Show("Se han guardado los datos");
            }
            //Limpiar
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Tipo { get; set; }

        }
    }
}
