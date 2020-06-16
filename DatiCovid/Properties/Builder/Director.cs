using Newtonsoft.Json.Linq;
namespace DatiCovid
{
    class Director
    {
        private IBuilder builder;

        public IBuilder Builder {
            set {
                builder = value;
            }
        }

        public void AndamentoNazionale(JObject s) {
            builder.data(s);
            builder.stato(s);
            builder.ricoverati_con_sintomi  (s);
            builder.totale_ospedalizzati (s);
            builder.isolamento_domiciliare (s);
            builder.totale_positivi (s);
            builder.variazione_totale_positivi (s);
            builder.nuovi_positivi (s);
            builder.dimessi_guariti (s);
            builder.deceduti (s);
            builder.totale_casi (s);
            builder.tamponi (s);
            builder.casi_testati (s);
            builder.note_it (s);
            builder.note_en (s);
        }
        public void Regione(JObject s) {
            builder.data(s);
            builder.stato(s);
            builder.codice_regione (s);
            builder.denominazione_regione (s);
            builder.latitutine (s);
            builder.longitudine (s);
            builder.ricoverati_con_sintomi(s);
            builder.terapia_intensiva(s);
            builder.totale_ospedalizzati(s);
            builder.isolamento_domiciliare(s);
            builder.totale_positivi(s);
            builder.variazione_totale_positivi(s);
            builder.nuovi_positivi(s);
            builder.dimessi_guariti(s);
            builder.deceduti(s);
            builder.totale_casi(s);
            builder.tamponi(s);
            builder.casi_testati(s);
            builder.note_it(s);
            builder.note_en(s);
        }
    }
}