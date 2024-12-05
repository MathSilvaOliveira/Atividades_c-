namespace ConversaodeMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Avaliar_Click(object sender, EventArgs e)
        {
            double dolarhj;
            double dolaron;
            double Result;

            dolarhj = Convert.ToDouble(textBox1.Text);
            dolaron = Convert.ToDouble(textBox2.Text);

            Result = ((dolarhj - dolaron)/dolarhj) * 100;

            double resultaAbs = Math.Abs(Result);

            string resultFormatted = resultaAbs.ToString("f2");

            if (Result >= 10){
                MessageBox.Show($"Difrença percentual: {resultFormatted}%. Recomenda-se comprar dolar hoje!!");
            }
            else
            {
                MessageBox.Show($"Difrença percentual: {resultFormatted}% Não é recomendado comprar o dolar hoje");
            }
        }
    }
}
