using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {

            Button testButton = new Button
            {
                Text = "Click me"
            };

            testButton.Clicked += OnTestButton_Clicked;

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        testButton
                    }
                }
            };
        }

        private void OnTestButton_Clicked(object sender, EventArgs e)
        {
            MainPage.DisplayAlert("Alert", "I'm a alert.", "Close");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
