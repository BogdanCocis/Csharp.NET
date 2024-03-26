using System.IO;

namespace WinFormsApp1_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;
            bool userFound = false;

            try
            {
                using (StreamReader sr = new StreamReader("users.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string usernameFromFile = parts[0].Trim();
                        string passwordFromFile = parts[1].Trim();

                        if (enteredUsername == usernameFromFile && enteredPassword == passwordFromFile)
                        {
                            userFound = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading user data: " + ex.Message);
                return;
            }

            if (userFound)
            {
                MessageBox.Show("Autentificare reușită!");
                Form1 welcomeForm = new Form1();
                welcomeForm.Show();
                this.Hide();
              
                Form2 welcomeForm2 = new Form2(enteredUsername);
                welcomeForm2.Show();
                welcomeForm.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }


    } 
}
