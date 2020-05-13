using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dependencias
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TextToSpeechDemo());

            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new QrCode());

            };

        }
    }
}
