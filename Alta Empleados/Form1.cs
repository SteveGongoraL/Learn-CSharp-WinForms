using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "" || txtGenero.Text == "" || txtDomicilio.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos para dar de alta");
            }
            else
            {
                int i = cbxArea.SelectedIndex;
                string area = Convert.ToString(cbxArea.Items[i]);
                
                List<usuario> _data = new List<usuario>();
                _data.Add(new usuario()
                {
                    Nombre = txtNombre.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Genero = txtGenero.Text,
                    Domicilio = txtDomicilio.Text,
                    Area = area
                });

                string json = JsonConvert.SerializeObject(_data.ToArray());

                if(area == "Finanzas")
                {
                    System.IO.File.AppendAllText(@"..\..\docs\RegistroFinanzas.json", json);
                }
                else if(area == "Recursos Humanos")
                {
                    System.IO.File.AppendAllText(@"..\..\docs\RegistroRH.json", json);
                }
                else if (area == "Tecnologia de Informacion")
                {
                    System.IO.File.AppendAllText(@"..\..\docs\RegistroTI.json", json);
                }
                else if (area == "Ventas")
                {
                    System.IO.File.AppendAllText(@"..\..\docs\RegistroVentas.json", json);
                }
                else
                {
                    System.IO.File.AppendAllText(@"..\..\docs\RegistroProduccion.json", json);
                }

                MessageBox.Show("Se ha registrado al empleado");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }
            public string Domicilio { get; set; }
            public string Area { get; set; }
        }
        //Cargar Areas
        public class AreasLoops
        {
            public Areas[] Elementos { get; set; }
        }
        public class Areas
        {
            public int ID { get; set; }
            public string Puesto { get; set; }
            public override string ToString() => Puesto;
        }
        public class JsonOperations
        {
            public static AreasLoops Read() =>
            JsonConvert.DeserializeObject<AreasLoops>(File.ReadAllText("..\\..\\docs\\AreasCarga.json"));
        }
        private void OnShown(object sender, EventArgs e)
        {
            cbxArea.DataSource = JsonOperations.Read().Elementos.ToList();
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
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
