namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hours = textBox1.Text;
            double converthours = Convert.ToDouble(hours);
            String miles = textBox2.Text;
            double convertmiles = Convert.ToDouble(miles);
            double baseprice = 200.0;
            double perhour = 150.0;
            double permile = 2.0;
            double sum = 200 + (converthours * perhour) + (convertmiles * permile);
            label3.Text = "Your Move will cost $" + sum;

        }
    }
}
