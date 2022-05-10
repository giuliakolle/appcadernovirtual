using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appcadernovirtual.SegundoAno;

namespace appcadernovirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiciplinasSegundo : ContentPage
    {
        public DiciplinasSegundo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.ArtesSegundo());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.BiologiaSegundo());
        }


        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.FisicaSegundo());
        }  


        private void Button_Clicked_3(object sender, EventArgs e)
        {
         Navigation.PushAsync(new SegundoAno.GeografiaSegundo());

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.HistoriaSegundo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.InglesSegundo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.MatematicaSegundo());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.PortuguesSegundo());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.QuimicaSegundo());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno.sociologiaSegundo());
        }
    }
}