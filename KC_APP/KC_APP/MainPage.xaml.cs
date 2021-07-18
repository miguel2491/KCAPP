using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using KC_APP.Views;

namespace KC_APP
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new detail())
            {
                BarBackgroundColor = Color.FromHex("#011e3c"),
                BarTextColor = Color.FromHex("#ffffff")
            };
            App.MasterD = this;
        }
    }
}
