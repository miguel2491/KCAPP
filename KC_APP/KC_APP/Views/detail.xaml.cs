using KC_APP.SQL;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KC_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class detail : ContentPage
    {
        public KC_DB db;
        public bool wifi = false;
        public detail()
        {
            InitializeComponent();
            if (!CrossConnectivity.Current.IsConnected)
            {
                //await DisplayAlert("Error", "Por favor activa tus datos o conectate a una red", "ok");
                btnSincro.IsEnabled = false;
            }
            else 
            {
                btnSincro.IsEnabled = true;
            }
        }

        private async void btnSincro_Clicked(object sender, EventArgs e)
        {
            db = new KC_DB();
            //Lugares
            var d_exist = db.GetEstablecimiento().ToList();
            var d_existe = db.GetEstablecimiento();
            int RowCount = 0;
            int usercount = d_existe.Count();
            RowCount = Convert.ToInt32(usercount);
            await DisplayAlert("S", "--->" + RowCount, "Aceptar");
            for (var x = 0; x < RowCount; x++)
            {
                await DisplayAlert("Success", "->" + d_exist[x].nombre, "Ok");
            }
            db.DeleteAllEstablecimiento();
            var dn_existe = db.GetEstablecimiento();
            usercount = dn_existe.Count();
            RowCount = Convert.ToInt32(usercount);
            await DisplayAlert("NV", "===>" + RowCount, "Ok");
            //Productos
            var lista_existe = db.GetProducto();
            var lista_ = db.GetProducto().ToList();
            int RowProducto = 0;
            int productoCount = lista_existe.Count();
            RowProducto = Convert.ToInt32(productoCount);
            await DisplayAlert("S","-->"+RowProducto,"Ok");
            for (var z = 0; z < RowProducto; z++)
            {
                await DisplayAlert("Success","----->"+lista_[z].nombre,"Aceptar");
            }
            db.DeleteAllProducto();
            var s_lista = db.GetEstablecimiento();
            productoCount = s_lista.Count();
            RowProducto = Convert.ToInt32(productoCount);
            await DisplayAlert("S","=>"+RowProducto,"OK");
            //Listas
        }
    }
}