using System;
using System.IO;

namespace DatiCovid
{
    class CheckDataDownload
    {
        private string data;
        private DateTime today;
        private bool b;

        public CheckDataDownload(string path) {
            this.b = true;
            if(File.Exists(path)){
                today = DateTime.Now;
                if(File.Exists("dati-raw-json/data.txt")){
                    StreamReader d = File.OpenText("dati-raw-json/data.txt");
                    while(!d.EndOfStream){ 
                        data = d.ReadLine();
                    }
                    DateTime T = DateTime.Parse(data);
                    this.b = (today.Subtract(T).TotalHours < 24) ? false : true; 
                }
            }
        }

        public bool GetB(){
            return this.b;
        }
    }
}