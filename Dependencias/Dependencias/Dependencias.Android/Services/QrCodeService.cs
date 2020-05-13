using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Dependencias.Services;
using ZXing.Mobile;
using Xamarin.Forms;
using System.Threading.Tasks;

[assembly: Dependency(typeof(Dependencias.Droid.Services.QrCodeService))]

namespace Dependencias.Droid.Services
{
    public class QrCodeService : IQrCodeService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Escaneé el codigo QR",
                BottomText = "Porfavor espere",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}