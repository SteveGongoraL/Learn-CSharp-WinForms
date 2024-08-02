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
    public partial class Form1 : Form
    {
        string super;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Validar campos llenos
            if (txtUsuario.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Es necesario poner ambos valores");
            }
            else
            {
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Usuario = txtUsuario.Text,
                    Contraseña = txtContra.Text,
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());

                //Escribiendo el archivo Json
                System.IO.File.AppendAllText(@"..\..\docs\01_RegistroSesion.json", json);


                //Cambiar de ventana.
                super = Convert.ToString(txtUsuario.Text);
                if (super == "ADMI")
                {
                    MessageBox.Show("Inicio de sesión como ADMI");
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    Form3 form = new Form3();
                    form.Show();
                    this.Hide();
                }
            }

        }
        public class usuario
        {
            public string Usuario { get; set; }
            public string Contraseña { get; set; }
        }
    }
}
