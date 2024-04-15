namespace WinFormsApp3_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // add button
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Introduceti numere valide in cele doua campuri.");
            }
        }


        private void button2_Click(object sender, EventArgs e) // substraction button
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Introduceti numere valide in cele doua campuri.");
            }
        }


        private void button3_Click(object sender, EventArgs e) // multiplication button
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Introduceti numere valide in cele doua campuri.");
            }
        }


        private void button4_Click(object sender, EventArgs e) // division button
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    textBox3.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Nu se poate imparti la zero!");
                }
            }
            else
            {
                MessageBox.Show("Introduceti numere valide in cele doua campuri.");
            }
        }


        private void button5_Click(object sender, EventArgs e) // clear button
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private double numar1; 

        private void textBox1_TextChanged(object sender, EventArgs e) //numar 1
        {
            if (double.TryParse(textBox1.Text, out double numar))
            {
                numar1 = numar; 
            }
            else
            {
                MessageBox.Show("Introduceti un numar valid in campul numar 1.");
            }
        }


        private void label3_Click(object sender, EventArgs e) //label  rezultat
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // afisare rezultat
        {

        }

        private double numar2; 

        private void textBox2_TextChanged(object sender, EventArgs e) // numarul 2
        {
            if (double.TryParse(textBox2.Text, out double numar))
            {
                numar2 = numar; 
            }
            else
            {
                MessageBox.Show("Introduceti un numar valid in campul numar 2.");
            }
        }

    }
}
