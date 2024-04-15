using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;


namespace WinFormsApp1_ex1
{
    public partial class Form2 : Form
    {
        Dictionary<string, string> imaginiElevi = new Dictionary<string, string>();
        private const string FileName = @"\\Mac\Home\Documents\AN III\II\Lucrarea_2\Tema_1_Catalog\WinFormsApp1_ex1\bin\Debug\net8.0-windows\students.txt";

        public Form2(string username)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
            imaginiElevi.Add("Harry", @"\\Mac\Home\Documents\AN III\II\Lucrarea_2\Tema_1_Catalog\WinFormsApp1_ex1\bin\Debug\net8.0-windows\harry.jpg");
            imaginiElevi.Add("Hermione", @"\\Mac\Home\Documents\AN III\II\Lucrarea_2\Tema_1_Catalog\WinFormsApp1_ex1\bin\Debug\net8.0-windows\pers1.jpg");
            imaginiElevi.Add("Ron", @"\\Mac\Home\Documents\AN III\II\Lucrarea_2\Tema_1_Catalog\WinFormsApp1_ex1\bin\Debug\net8.0-windows\pers3.jpg");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    writer.WriteLine("Harry");
                    writer.WriteLine("Hermione");
                    writer.WriteLine("Ron");
                }
                using (StreamReader str = new StreamReader(FileName))
                {
                    string line;
                    while ((line = str.ReadLine()) != null)
                    {
                        studentListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la operarea cu fisierul: " + ex.Message);
            }
        }


        // Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Students List
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                string studentName = studentListBox.SelectedItem.ToString();

                if (studentName == "Harry")
                {
                    mediaTextBox.Text = "9.5";
                    textBox2.Text = "9.8";
                    pictureBox1.ImageLocation = imaginiElevi["Harry"];
                }
                else if (studentName == "Hermione")
                {
                    mediaTextBox.Text = "8.7";
                    textBox2.Text = "8.9";
                    pictureBox1.ImageLocation = imaginiElevi["Hermione"];
                }
                else if (studentName == "Ron")
                {
                    mediaTextBox.Text = "7.8";
                    textBox2.Text = "7.5";
                    pictureBox1.ImageLocation = imaginiElevi["Ron"];
                }
            }
        }

        // logout menu
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        // Help 
        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpMessage = "Catalogul este destinat afisarii listei de studenti. " +
                                 "Pentru a vedea detalii despre un student, selectati-l din lista si apasati butonul 'View'. " +
                                 "Pentru a va deconecta, apasati butonul 'Logout'. " +
                                 "Pentru orice intrebari suplimentare, contactati administratorul.";

            MessageBox.Show(helpMessage, "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Mean TextBox
        private void mediaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // MeanP TextBox   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // View button
        private void View_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
