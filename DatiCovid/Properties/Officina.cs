using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Gtk;

namespace DatiCovid
{
    class Officina
    {
        private LoadProxy LP;
        private Liste regione;
        private List<Liste> attributi;
        private DatiProxy DN;
        private DatiProxy DR;
        private string data = "";
        private static readonly string url_n = "https://raw.githubusercontent.com/pcm-dpc/COVID-19/master/dati-json/dpc-covid19-ita-andamento-nazionale-latest.json";
        private static readonly string url_r = "https://raw.githubusercontent.com/pcm-dpc/COVID-19/master/dati-json/dpc-covid19-ita-regioni-latest.json";            
        private static readonly string path_n = "dati-raw-json/andamento_nazionale.json";
        private static readonly string path_r = "dati-raw-json/regioni_latest.json";
        
        public Officina(){
        }

        public void StampaDati(ref Label lb, int i) {
            this.LP = new LoadProxy(ref lb, attributi[i]);
            LP.CaricaDati(ref lb, attributi[i]);
               
        }
        public void Aggiorna(ref Label lbItalia, ref Label lbInfo2){
            Directory.CreateDirectory("dati-raw-json");
            Directory.CreateDirectory("dati-ordinati");
            this.DN = new DatiProxy(url_n, path_n);
            this.DR = new DatiProxy(url_r, path_r);
            this.regione = new Liste("denominazione_regione");
            this.attributi = new List<Liste>();
            this.attributi.Add(new Liste("Italia"));
            this.attributi.Add(new Liste("variazione_totale_positivi"));
            this.attributi.Add(new Liste("totale_casi"));
            this.attributi.Add(new Liste("totale_positivi"));
            this.attributi.Add(new Liste("dimessi_guariti"));
            this.attributi.Add(new Liste("deceduti"));

            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            
            try {
                foreach(JObject jobj in this.DN.DownloadDati()) {
                    director.AndamentoNazionale(jobj);
                    Product p = builder.GetProduct();
                    data = p.GetData();
                    attributi[0].dictionary = p.GetParts();
                }
            
                foreach(JObject jobj in this.DR.DownloadDati()) {
                    director.Regione(jobj);
                    Product p = builder.GetProduct();
                    string reg = regione.GetPart(p);
                    for(int i = 1; i < attributi.Count; i++ ){
                        attributi[i].dictionary.Add(reg, attributi[i].GetPart(p));
                    }
                }
                foreach(Liste l in attributi){
                    l.Order();
                }
                File.WriteAllText("dati-raw-json/data.txt", data);
                lbInfo2.Text = "\n_Dati aggiornati\n con successo!!\n";
            } catch (Exception){
                lbInfo2.Text = "\nAggiornamento non riuscito,\ncontrolla la connessione!!\n";
            } finally {
                this.StampaDati(ref lbItalia, 0);
            }
        }
    }
}