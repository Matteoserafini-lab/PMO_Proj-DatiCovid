using Newtonsoft.Json.Linq;
using System;

namespace DatiCovid
{
    class DatiProxy : IDati
    {
        private Dati _dati;
        private string _url;
        private string _path;
        private CheckDataDownload check;
        public DatiProxy(string url, string path) {    
            this._url = url;
            this._path = path;

            if (this.check == null){
                this.check = new CheckDataDownload(this._path);
            }
        }

        private Dati GetDati() {
            this._dati = new Dati(_url, _path, check.GetB());     
            return this._dati;
        }
        public JArray DownloadDati() {
            try{
                return GetDati().DownloadDati();
            } catch (Exception) {
                throw;
            }
        }  
    }
}