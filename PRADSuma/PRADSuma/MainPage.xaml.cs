using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PRADSuma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnSuma_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("El Resultado de la Suma es",Convert.ToString(Convert.ToDouble(Numero1.Text) + Convert.ToDouble(Numero2.Text)),"Ok");
        }

        private async void BtnResta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("El Resultado de la Resta es", Convert.ToString(Convert.ToDouble(Numero1.Text) - Convert.ToDouble(Numero2.Text)), "Ok");
        }

        private async void BtnMultiplica_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("El Resultado de la Multiplicacion es", Convert.ToString(Convert.ToDouble(Numero1.Text) * Convert.ToDouble(Numero2.Text)), "Ok");
        }

        private async void BtneDivide_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("El Resultado de la Divicion es", Convert.ToString(Convert.ToDouble(Numero1.Text) / Convert.ToDouble(Numero2.Text)), "Ok");
        }
    }
}
