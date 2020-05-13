using Dependencias.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dependencias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QrCode : ContentPage
    {
        public QrCode()
        {
            InitializeComponent();
        }
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQrCodeService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}