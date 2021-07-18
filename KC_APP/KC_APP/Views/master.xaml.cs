using KC_APP.Views.Azula;
using KC_APP.Views.Lugares;
using KC_APP.Views.Productos;
using KC_APP.Views.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KC_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
            //btnListado.ImageSource = ImageSource.FromFile("drawable.icons.lista.png");
        }

        private async void btnAzulaEco_Tapped(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new EcoAzula());
        }

        private async void btnLugar_Tapped(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Establecimiento());
        }

        private async void btnProductoNuevo_Tapped(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await ((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new AddProducto());
        }

        private async void btnListado_Tapped(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Lista());
        }
    }
}