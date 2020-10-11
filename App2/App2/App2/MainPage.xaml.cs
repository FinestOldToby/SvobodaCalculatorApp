using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnPrecist(object sender, EventArgs e)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a + b).ToString();
        }
        private void BtnOdecist(object sender, EventArgs e)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a - b).ToString();
        }
        private void BtnVynasobit(object sender, EventArgs e)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a * b).ToString();
        }
        private void BtnDelit(object sender, EventArgs e)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a / b).ToString();
        }
        private void BtnDelitAZiskatZbytek(object sender, EventArgs e)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a % b).ToString();
        }
        private void BtnVycistitPole(object sender, EventArgs e)
        {
            cislo1.Text = String.Empty;
            cislo2.Text = String.Empty;
            vysledek.Text = String.Empty;
        }
    }
}