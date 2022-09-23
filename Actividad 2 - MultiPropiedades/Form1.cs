namespace Actividad_2___MultiPropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Multiplicar mult = new Multiplicar();
            mult.Num1 = int.Parse(Valor1.Text);
            mult.Num2 = int.Parse(Valor2.Text);

            Resultado.Text = mult.multiplicar().ToString();
        }
    }
}