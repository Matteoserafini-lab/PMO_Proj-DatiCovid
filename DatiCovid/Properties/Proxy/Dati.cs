using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DatiCovid
{
    class Dati : IDati
    {
        private string _url;
        private string _path;
        private bool flag;
        internal Dati(string url, string path, bool b){
            this._path = path;
            this._url = url;
            this.flag = b;
        }

        public JArray DownloadDati() {
            try {
                if (this.flag == true){
                    using (System.Net.WebClient wc = new System.Net.WebClient()){
                        wc.DownloadFile(this._url,this. _path);
                    }
                }
                return this.ParseDati();
            } catch (Exception){
                throw;
            }
        }
        private JArray ParseDati(){
            return JArray.Parse(File.ReadAllText(_path));
        }
    }
}