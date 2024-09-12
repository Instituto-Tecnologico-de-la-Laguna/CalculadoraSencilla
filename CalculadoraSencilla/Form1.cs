using System.Diagnostics;
namespace CalculadoraSencilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1=Convert.ToInt32(txtValor1.Text);
                int valor2=Convert.ToInt32(txtValor2.Text);
                double resultado = 0;

                if (rdbSuma.Checked == true)
                {
                    resultado = valor1 + valor2;
                    Debug.WriteLine(resultado.ToString());
                }
                else if (rdbResta.Checked == true)
                    resultado = valor1 - valor2;
                else if (rdbMultiplicacion.Checked == true)
                    resultado = valor1 * valor2;
                else
                    resultado = valor1 / valor2;
                txtResultado.Text = resultado.ToString();

            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
