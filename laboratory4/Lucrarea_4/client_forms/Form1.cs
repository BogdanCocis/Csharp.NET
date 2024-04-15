using Lucrarea_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_forms
{
    public partial class Form1 : Form
    {
        private Lucrarea_4.WebService1 webServiceClient;


        public Form1()
        {
            InitializeComponent();
            webServiceClient = new Lucrarea_4.WebService1();
        }
        private void AfisareDataSiOra()
        {
            DateTime currentDateAndTime = webServiceClient.GetCurrentDateTime();
            dataTextBox.Text = currentDateAndTime.ToShortDateString();
            oraTextBox.Text = currentDateAndTime.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareDataSiOra();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void temperaturaCTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void adaugareListaButton_Click(object sender, EventArgs e)
        {
            List<string> items = webServiceClient.GetList();
            lista.Items.Clear();
            lista.Items.AddRange(items.ToArray());
        }

     

        private void TempC_Click(object sender, EventArgs e)
        {

        }

        private void TempF_Click(object sender, EventArgs e)
        {

        }

        private void tempFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rezConv_Click(object sender, EventArgs e)
        {

        }

        private void rezultatConversieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FToCbutton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tempFTextBox.Text, out double temperatureFahrenheit))
            {
                double temperatureCelsius = webServiceClient.FahrenheitToCelsius(temperatureFahrenheit);
                rezultatConversieTextBox.Text = temperatureCelsius.ToString();
            }
            else
            {
                MessageBox.Show("Te rog introdu o valoare valida pentru temperatura Fahrenheit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CToFButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(temperaturaCTextBox.Text, out double temperatureCelsius))
            {
                double temperatureFahrenheit = webServiceClient.CelsiusToFahrenheit(temperatureCelsius);
                rezultatConversieTextBox.Text = temperatureFahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Te rog introdu o valoare valida pentru temperatura Celsius.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void EuroToRonLabel_Click(object sender, EventArgs e)
        {

        }

        private void sumaRonTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SumaEuroTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void euroToRonButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(SumaEuroTextBox.Text, out double euroAmount))
            {
                try
                {
                    double convertedAmountInRON = webServiceClient.ConvertCurrencyToEuro(euroAmount);
                    sumaRonTextBox.Text = convertedAmountInRON.ToString("0.00 euro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conversia sumei!" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Te rog introdu o valoare valida pentru suma in euro.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ora_Click(object sender, EventArgs e)
        {

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}