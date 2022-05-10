using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcadernovirtual.TerceiroAno;






using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appcadernovirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiciplinasTerceiro : ContentPage
    {
        public DiciplinasTerceiro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.Biologia());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.FisicaTerceiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.GeografiaTerceiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.HistoriaTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.InglesTerceiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.MatematicaTerceiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.Portuguesterceiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.QuimicaTerceiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno.SociologiaTerceiro());
        }
    }
}