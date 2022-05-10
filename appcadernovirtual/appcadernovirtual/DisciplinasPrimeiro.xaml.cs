using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appcadernovirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisciplinasPrimeiro : ContentPage
    {
        public DisciplinasPrimeiro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.ArtesPrimeiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.HistoriaSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.GeografiaPrimeiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.SociologiaPrimeiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.FisicaPrimeiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.QuimicaPrimeiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.MatematicaPrimeiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.BiologiaPrimeiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.portuguesPrimeiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno.InglesPrimeiro());
        }
    }
}