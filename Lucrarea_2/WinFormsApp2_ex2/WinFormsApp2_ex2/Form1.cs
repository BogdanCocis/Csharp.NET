using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2_ex2
{
    public partial class Form1 : Form
    {
        private const string FileName = @"D:\FACULTATE\AN III sem 2\II\WinFormsApp2_ex2\WinFormsApp2_ex2\bin\Debug\net8.0-windows\fisier.txt";

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    writer.WriteLine("Laptop");
                    writer.WriteLine("Casti");
                    writer.WriteLine("Mouse");
                    writer.WriteLine("Tastatura");
                    writer.WriteLine("Monitor");
                }
                using (StreamReader str = new StreamReader(FileName))
                {
                    string line;
                    while ((line = str.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la operarea cu fișierul: " + ex.Message);
            }
        }


        private void Copiaza_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            listBox1.ClearSelected();
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox2.SelectedItems.OfType<string>().ToList())
            {
                listBox2.Items.Remove(item);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
