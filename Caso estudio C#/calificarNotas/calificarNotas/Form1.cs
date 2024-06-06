namespace calificarNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);

            Controlador controlador = new Controlador();
            double notaFinal = controlador.CalcularNotaFinal(nota1, nota2, nota3);

            lblNotaFinal.Text = "Nota Final: " + notaFinal;

            controlador.GuardarEnBD(nombre, nota1, nota2, nota3, notaFinal);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNotaFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
