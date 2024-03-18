namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = new Bitmap("D:\\FACULTATE\\AN III sem 2\\II\\WinFormsApp4\\WinFormsApp4\\bin\\Debug\\net6.0-windows\\Audi_A7.jpg");
                    break;
                case 1:
                    pictureBox1.Image = new Bitmap("D:\\FACULTATE\\AN III sem 2\\II\\WinFormsApp4\\WinFormsApp4\\bin\\Debug\\net6.0-windows\\ROW03420.jpg");
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg1 = string.Empty, msg2 = string.Empty;
            foreach (RadioButton rb in Inghetata.Controls) { 
                if(rb.Checked == true)
                {
                    msg1 = rb.Text; 
                }
            }
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked == true)
                {
                    msg2 = rb.Text;
                }
            }
            MessageBox.Show("Ati comandat o inghetata " + msg1 + " cu aroma de " + msg2, "Comanda");
            foreach (RadioButton rb in Inghetata.Controls)
            {
                if (rb.Checked == true)
                {
                    rb.Checked = false;
                }
            }
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked == true)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}