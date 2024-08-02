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

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
            Shown += OnShown2;
        }
        int suma = 0;
        //Cargar Productos
        public class DatosLoops
        {
            public Datos[] Elementos { get; set; }
        }
        public class Datos
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public override string ToString() => Nombre;
        }
        public class JsonOperations
        {
            public static DatosLoops Read() =>
            JsonConvert.DeserializeObject<DatosLoops>(File.ReadAllText("../../docs/Inventario.json"));
        }
        private void OnShown(object sender, EventArgs e)
        {
            cbxProducto.DataSource = JsonOperations.Read().Elementos.ToList();
        }
        //Cargar Precios
        public class PrecioLoops
        {
            public DatosPrecio[] Elementos { get; set; }
        }
        public class DatosPrecio
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public override string ToString() => Precio;
        }
        public class JsonOperations2
        {
            public static PrecioLoops Read() =>
            JsonConvert.DeserializeObject<PrecioLoops>(File.ReadAllText("../../docs/Inventario.json"));
        }
        private void OnShown2(object sender, EventArgs e)
        {
            cbxPrecios.DataSource = JsonOperations2.Read().Elementos.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Declarar variables
            string producto, precioUnitario, cantidadProducto, totalProductoStr;
            int totalProducto, indiceElemento;
            
            // Producto
            indiceElemento = cbxProducto.SelectedIndex;
            producto = Convert.ToString(cbxProducto.Items[indiceElemento]);
            
            // Precio unitario
            precioUnitario = Convert.ToString(cbxPrecios.Items[indiceElemento]);
            
            // Cantidad a pedir
            if(txtCantidad.Text == "")
            {
                cantidadProducto = "1";
            }
            else
            {
                cantidadProducto = Convert.ToString(txtCantidad.Text);
            }

            // Total
            totalProducto = Convert.ToInt32(precioUnitario) * Convert.ToInt32(cantidadProducto);
            totalProductoStr = Convert.ToString(totalProducto);

            // Limpiar
            txtCantidad.Text = string.Empty;
            lblTotal.Text = string.Empty;

            // Llenar la tabla
            dg1.Rows.Add(producto, precioUnitario, cantidadProducto, totalProductoStr);

            List<usuario> _data = new List<usuario>();
            _data.Add(new usuario()
            {
                Nombre = producto,
                Precio = precioUnitario,
                Cantidad = cantidadProducto,
                Total = totalProductoStr,
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.AppendAllText(@"../../docs/RegistroCompras.json", json);
        }
        public class usuario
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidad { get; set; }
            public string Total { get; set; }

        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            // Declarar variables
            string producto, precioUnitario, cantidadProducto, totalProductoStr;
            int totalProducto, indiceElemento;

            // Producto
            indiceElemento = cbxProducto.SelectedIndex;
            producto = Convert.ToString(cbxProducto.Items[indiceElemento]);

            // Precio unitario
            precioUnitario = Convert.ToString(cbxPrecios.Items[indiceElemento]);

            // Cantidad a pedir
            if (txtCantidad.Text == "")
            {
                cantidadProducto = "1";
            }
            else
            {
                cantidadProducto = Convert.ToString(txtCantidad.Text);
            }

            // Total
            totalProducto = Convert.ToInt32(precioUnitario) * Convert.ToInt32(cantidadProducto);
            totalProductoStr = Convert.ToString(totalProducto);
            lblTotal.Text = totalProductoStr;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg1.RowCount - 1; i++)
            {
                suma += int.Parse(dg1.Rows[i].Cells[3].Value.ToString());
            }
            MessageBox.Show("El total de su compra es: $" + suma);
            List<subtotal> _data = new List<subtotal>();
            _data.Add(new subtotal()
            {
                Subtotal = Convert.ToString(suma),
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());

            //Escribiendo el archivo Json
            System.IO.File.AppendAllText(@"../../docs/RegistroCompras.json", json);

            // Limpiando la pagina
            txtCantidad.Text = string.Empty;
            lblTotal.Text = string.Empty;
            dg1.Rows.Clear();
            suma = 0;
        }
        public class subtotal
        {
            public string Subtotal { get; set; }
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }
    }
}
