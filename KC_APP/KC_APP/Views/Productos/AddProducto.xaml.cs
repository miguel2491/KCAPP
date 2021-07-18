using KC_APP.Models;
using KC_APP.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KC_APP.Views.Productos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProducto : ContentPage
    {
        public KC_DB kc_db;
        public AddProducto()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //--DB
            kc_db = new KC_DB();
            var prodDB = new Producto();
            var nombre = producto.Text;
            var precio = Convert.ToDouble(Precio.Text);
            var cantidad = Convert.ToInt32(Cantidad.Text);
            //---------------------------
            prodDB.nombre = nombre;
            prodDB.precio = precio;
            prodDB.cantidad = cantidad;
            kc_db.AddProducto(prodDB);
            //---------------------------
            await DisplayAlert("Success", "Se Agrego correctamente", "OK");
            App.MasterD.IsPresented = false;
            await ((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MainPage());
        }
    }
}