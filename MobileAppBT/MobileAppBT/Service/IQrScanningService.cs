using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppBT.Service
{
    internal interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
