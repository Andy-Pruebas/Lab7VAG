using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dependencias.Services
{
    public interface IQrCodeService
    {
        Task<string> ScanAsync();
    }
}
