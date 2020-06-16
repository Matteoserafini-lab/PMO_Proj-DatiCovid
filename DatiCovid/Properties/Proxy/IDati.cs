using Newtonsoft.Json.Linq;

namespace DatiCovid
{
    interface IDati
    {
        JArray DownloadDati();
    }
}