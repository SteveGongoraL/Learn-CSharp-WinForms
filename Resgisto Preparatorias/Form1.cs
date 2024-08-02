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
using System.IO;

namespace RegistroPreparatorias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Nombre = txtNombre.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Escuela = lblP.Text
                });

                string json = JsonConvert.SerializeObject(_data.ToArray());

                System.IO.File.AppendAllText(@"..\..\docs\\DatosGuardados.json", json);

                MessageBox.Show("Se han guardado los datos");
            }
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Escuela { get; set; }
        }
        private void cBoxCarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            int g = cBoxCarga.SelectedIndex;
            string prepa = Convert.ToString(cBoxCarga.Items[g]);
            lblP.Text = Convert.ToString(prepa);
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public class DatosLoops
        {
            public Datos[] Elementos { get; set; }
        }
        public class Datos
        {
            public string Nombre { get; set; }
            public string Municipio { get; set; }
            public override string ToString() => Nombre;
        }
        public class JsonOperations
        {
            public static DatosLoops Read() =>
            JsonConvert.DeserializeObject<DatosLoops>(File.ReadAllText("..\\..\\docs\\DatosCarga.json"));
        }
        private void OnShown(object sender, EventArgs e)
        {
            cBoxCarga.DataSource = JsonOperations.Read().Elementos.OrderBy(elemento => elemento.Nombre).ToList();
        }

    }
}
