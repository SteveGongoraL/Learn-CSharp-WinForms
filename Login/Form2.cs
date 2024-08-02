using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (txtCorreo.Text == "" || txtEdad.Text == "" || txtUsuario.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Correo = txtCorreo.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Usuario = txtUsuario.Text,
                    Contraseña = Convert.ToInt32(txtContra.Text),
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());
                System.IO.File.AppendAllText(@"..\..\docs\02_Signup.json", json);
                MessageBox.Show("Se ha creado la cuenta");
            }
        }
        public class usuario
        {
            public string Correo { get; set; }
            public int Edad { get; set; }
            public string Usuario { get; set; }
            public int Contraseña { get; set; }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '_') && (e.KeyChar != '.') && (e.KeyChar != '@'))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("El usuario solo debe contener letras. \nLa contraseña solo debe contener numeros.");
        }
    }
}
