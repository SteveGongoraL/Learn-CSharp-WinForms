namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultadoOperacion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtBoxNumero1.Text == "" || txtBoxNumero2.Text == "")
            {
                MessageBox.Show("Es necesario poner ambos numeros");
            }
            else
            {
                resultadoOperacion = Convert.ToDouble(txtBoxNumero1.Text) + Convert.ToDouble(txtBoxNumero2.Text);
                txtBoxResultado.Text = Convert.ToString(resultadoOperacion);
                lblOperacion.Text = "+";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtBoxNumero1.Text == "" || txtBoxNumero2.Text == "")
            {
                MessageBox.Show("Es necesario poner ambos numeros");
            }
            else
            {
                resultadoOperacion = Convert.ToDouble(txtBoxNumero1.Text) - Convert.ToDouble(txtBoxNumero2.Text);
                txtBoxResultado.Text = Convert.ToString(resultadoOperacion);
                lblOperacion.Text = "-";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtBoxNumero1.Text == "" || txtBoxNumero2.Text == "")
            {
                MessageBox.Show("Es necesario poner ambos numeros");
            }
            else
            {
                resultadoOperacion = Convert.ToDouble(txtBoxNumero1.Text) * Convert.ToDouble(txtBoxNumero2.Text);
                txtBoxResultado.Text = Convert.ToString(resultadoOperacion);
                lblOperacion.Text = "x";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtBoxNumero1.Text == "" || txtBoxNumero2.Text == "")
            {
                MessageBox.Show("Es necesario poner ambos numeros");
            }
            else
            {
                resultadoOperacion = Convert.ToDouble(txtBoxNumero1.Text) / Convert.ToDouble(txtBoxNumero2.Text);
                txtBoxResultado.Text = Convert.ToString(resultadoOperacion);
                lblOperacion.Text = "/";
            }
        }

        // Validar solo numeros
        private void txtBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
