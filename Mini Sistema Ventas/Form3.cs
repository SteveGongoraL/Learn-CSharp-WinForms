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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            int total = Convert.ToInt32(lblPrecio1.Text) + Convert.ToInt32(lblPrecio2.Text) + Convert.ToInt32(lblPrecio3.Text) + Convert.ToInt32(lblPrecio4.Text) + Convert.ToInt32(lblPrecio5.Text) + Convert.ToInt32(lblPrecio6.Text);

            List<usuario> _data = new List<usuario>();
            _data.Add(new usuario()
            {
                Mandalorian = lblPrecio1.Text,
                Aquaman = lblPrecio2.Text,
                Hogwarts = lblPrecio3.Text,
                Flash = lblPrecio4.Text,
                Shield = lblPrecio5.Text,
                Simba = lblPrecio6.Text,
                Total = Convert.ToString(total),
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());

            //Escribiendo el archivo Json
            System.IO.File.AppendAllText(@"..\..\docs\04_Compras.json", json);
            MessageBox.Show("El total de la compra es: $" + Convert.ToString(total));
        }
        public class usuario
        {
            public string Mandalorian { get; set; }
            public string Aquaman { get; set; }
            public string Hogwarts { get; set; }
            public string Flash { get; set; }
            public string Shield { get; set; }
            public string Simba { get; set; }
            public string Total { get; set; }

        }

        private void cBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int g = cBox1.SelectedIndex;
            int g2 = Convert.ToInt32(cBox1.Items[g]) * 199;
            lblPrecio1.Text = Convert.ToString(g2);
        }

        private void cBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = cBox2.SelectedIndex;
            int s2 = Convert.ToInt32(cBox2.Items[s]) * 199;
            lblPrecio2.Text = Convert.ToString(s2);
        }

        private void cBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = cBox3.SelectedIndex;
            int b2 = Convert.ToInt32(cBox3.Items[b]) * 699;
            lblPrecio3.Text = Convert.ToString(b2);
        }

        private void cBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l = cBox4.SelectedIndex;
            int l2 = Convert.ToInt32(cBox4.Items[l]) * 299;
            lblPrecio4.Text = Convert.ToString(l2);
        }

        private void cBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cBox5.SelectedIndex;
            int a2 = Convert.ToInt32(cBox5.Items[a]) * 399;
            lblPrecio5.Text = Convert.ToString(a2);
        }

        private void cBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = cBox6.SelectedIndex;
            int c2 = Convert.ToInt32(cBox6.Items[c]) * 199;
            lblPrecio6.Text = Convert.ToString(c2);
        }
    }
}
