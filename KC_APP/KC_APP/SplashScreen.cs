using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KC_APP
{
    class SplashScreen : ContentPage
    {
        Image splashImage;

        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            //            NavigationPage.BarBackgroundColorProperty(Color.FromHex("#225374"));


            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "BabyBlue.png",
                WidthRequest = 200,
                HeightRequest = 200,
                Opacity = 0
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                 AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("225374");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.FadeTo(1, 150, null);
            await splashImage.ScaleTo(1, 1000); //Time-consuming processes such as initialization
            await splashImage.ScaleTo(0.6, 1500, Easing.BounceOut);
            await splashImage.FadeTo(0, 270, null);

            //userDataBase = new UserDataBase();
            //var user_exist = userDataBase.GetMembers().ToList();
            //int RowCount = 0;
            //int usercount = user_exist.Count();
            //RowCount = Convert.ToInt32(usercount);
            /*if (RowCount == 1)
            {
                var ux = user_exist[0].id_cliente;
                if (ux != 0)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    Application.Current.MainPage = new NavigationPage(new Banner());
                }
            }
            else { Application.Current.MainPage = new NavigationPage(new Banner()); }
            */
            Application.Current.MainPage = new NavigationPage(new Login());
        }
    }
}
