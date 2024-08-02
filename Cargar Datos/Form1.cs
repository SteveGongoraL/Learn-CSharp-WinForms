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

namespace CargarDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int indice = comboBoxProducto.SelectedIndex;
            string producto = Convert.ToString(comboBoxProducto.Items[indice]);

            List<usuario> _data = new List<usuario>();
            _data.Add(new usuario()
            {
                Nombre = textBoxNombre.Text,
                Direccion = textBoxDireccion.Text,
                Producto = producto
            });

            string json = JsonConvert.SerializeObject(_data.ToArray());

            System.IO.File.AppendAllText(@"..\..\docs\DatosGuardados.json", json);

            MessageBox.Show("Se guardaron los datos de compra");
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Producto { get; set; }
        }
        public class ProductosC
        {
            public Datos[] Productos { get; set; }
        }
        public class Datos
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public override string ToString() => Nombre;
        }
        public class JsonOperations
        {
            public static ProductosC Read() =>
            JsonConvert.DeserializeObject<ProductosC>(File.ReadAllText("..\\..\\docs\\CatalogoProductos.json"));
        }
        private void OnShown(object sender, EventArgs e)
        {
            comboBoxProducto.DataSource = JsonOperations.Read().Productos.OrderBy(elemento => elemento.Nombre).ToList();
        }
    }
}
