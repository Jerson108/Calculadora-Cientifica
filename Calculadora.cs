using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Calculadora : Form
    {
        private bool temaOscuro = false;
        private double memoria = 0;
        private List<string> historial = new List<string>();
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxResultado.TextAlign = HorizontalAlignment.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBoxResultado.Text.Contains("."))
            {
                textBoxResultado.Text += ".";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text.Length > 0)
            {
                textBoxResultado.Text = textBoxResultado.Text.Remove(textBoxResultado.Text.Length - 1, 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxResultado.Text) && !textBoxResultado.Text.Equals("0"))
            {
                if (textBoxResultado.Text[0] == '-')
                {
                    textBoxResultado.Text = textBoxResultado.Text.Substring(1);
                }
                else
                {
                    textBoxResultado.Text = "-" + textBoxResultado.Text;
                }
            }

        }


        private double Evaluate(string expression)
        {
            // Utilizar la clase DataTable.Compute para evaluar la expresión
            var dataTable = new System.Data.DataTable();
            var result = dataTable.Compute(expression, "");
            return Convert.ToDouble(result);
        }

        //el boton =
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Evaluar la expresión matemática y mostrar el resultado
                textBoxResultado.Text = Evaluate(textBoxResultado.Text).ToString();
            }
            catch (Exception ex)
            {
                textBoxResultado.Text = "Error";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResultado.Text += button.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operador_Click(sender, e);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operador_Click(sender, e);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operador_Click(sender, e);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operador_Click(sender, e);
        }

        private void btnC_Click_Click(object sender, EventArgs e)
        {
            CambiarTemaClaro();
        }

        private void btnN_Click_Click(object sender, EventArgs e)
        {
            CambiarTemaOscuro();
        }

        private void CambiarTemaClaro()
        {
            // Cambiar propiedades visuales para el tema claro
            this.BackColor = Color.White;
            textBoxResultado.BackColor = Color.White;
            textBoxResultado.ForeColor = Color.Black;
            // Puedes agregar más elementos según sea necesario

            // Actualizar el estado del tema
            temaOscuro = false;
        }

        private void CambiarTemaOscuro()
        {
            // Cambiar propiedades visuales para el tema oscuro
            this.BackColor = Color.DarkGray;
            textBoxResultado.BackColor = Color.DarkGray;
            textBoxResultado.ForeColor = Color.White;
            // Puedes agregar más elementos según sea necesario

            // Actualizar el estado del tema
            temaOscuro = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            if (double.TryParse(textBoxResultado.Text, out double numero))
            {
                //formula para calcular raiz cuadrada
                textBoxResultado.Text = Math.Sqrt(numero).ToString();
            }

            else
            {
                // como la calculadora esta configurada para que primer se ponga el numero 
                // despues la operacion, en este caso si el se pone la operacion y despues
                // el numero aparece un msms de error en la pantalla
                MessageBox.Show("Por favor, ingrese un número antes de calcular la raíz cuadrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // calcular el cuadrado de esto
            textBoxResultado.Text = Math.Pow(numero, 2).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // Calculo para el seno
            textBoxResultado.Text = Math.Sin(numero).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // calculo para el cos
            textBoxResultado.Text = Math.Cos(numero).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // calculo para la tang
            textBoxResultado.Text = Math.Tan(numero).ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // calculo para el logaritmo natural
            textBoxResultado.Text = Math.Log(numero).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // calculo para logaritmo base 10
            textBoxResultado.Text = Math.Log10(numero).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            // Calculo para el porcentaje
            textBoxResultado.Text = (numero / 100).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // esto nos da para el numero actual en la pantalla pero de otra forma se plantea
            int numero = int.Parse(textBoxResultado.Text);

            // calculo para el factorial
            long resultado = 1;
            for (int i = 1; i < numero; i++)
            {
                resultado *= i;
            }

            textBoxResultado.Text = resultado.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // aca se da el resultado de pi defrente no hay formula alguna como las anteriores
            textBoxResultado.Text = Math.PI.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // esto de aca es para que nos muestre el numero en la pantalla
            double numero = double.Parse(textBoxResultado.Text);

            textBoxResultado.Text = Math.Pow(10, numero).ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxResultado.Text, out double numero))
            {
                // sumamos el número actual a la memoria
                memoria += numero;
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un número antes de utilizar M+.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxResultado.Text, out double numero))
            {
                // restamos  el número actual a la memoria
                memoria -= numero;
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un número antes de utilizar M+.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = memoria.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //Limpiamos la memoria que se almacena
            memoria = 0;
        }
    }
}
