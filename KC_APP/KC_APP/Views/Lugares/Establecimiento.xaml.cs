using KC_APP.SQL;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KC_APP.Models;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace KC_APP.Views.Lugares
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Establecimiento : ContentPage
    {
        public KC_DB kc_db;
        public Establecimiento establecimiento;
        public Establecimiento()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var pos = await CrossGeolocator.Current.GetPositionAsync();

            Mapx.MoveToRegion(
                MapSpan.FromCenterAndRadius(
            new Position(pos.Latitude, pos.Longitude), Distance.FromMiles(1)));


            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(pos.Latitude, pos.Longitude),
                Label = "Mi ubicacion",
                Address = "  usted se encuentra aqui",

            };
            Mapx.Pins.Add(pin);
        }

        private async void btn_Guardar_Clicked(object sender, EventArgs e)
        {
            kc_db = new KC_DB();
            var lugarW = new KC_APP.Models.Establecimiento();
            var pos = await CrossGeolocator.Current.GetPositionAsync();
            var nombreL = Nombre.Text;
            var lat = pos.Latitude;
            var lon = pos.Longitude;
            lugarW.nombre = nombreL;
            lugarW.lat = Convert.ToString(lat);
            lugarW.lon = Convert.ToString(lon);
            kc_db.AddEstablecimiento(lugarW);
            await DisplayAlert("Success", "Se Agrego correctamente:"+lon, "OK");
            Application.Current.MainPage = new MainPage();
        }
    }
}