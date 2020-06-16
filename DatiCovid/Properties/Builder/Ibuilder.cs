using Newtonsoft.Json.Linq;
namespace DatiCovid
{
    public interface IBuilder
    {
        void data(JObject s);
        void stato (JObject s);
        void codice_regione (JObject s);
        void denominazione_regione (JObject s);
        void codice_provincia (JObject s);
        void denominazione_provincia (JObject s);
        void sigla_provincia (JObject s);
        void latitutine (JObject s);
        void longitudine (JObject s);
        void ricoverati_con_sintomi  (JObject s);
        void terapia_intensiva (JObject s);
        void totale_ospedalizzati (JObject s);
        void isolamento_domiciliare (JObject s);
        void totale_positivi (JObject s);
        void variazione_totale_positivi (JObject s);
        void nuovi_positivi (JObject s);
        void dimessi_guariti (JObject s);
        void deceduti (JObject s);
        void totale_casi (JObject s);
        void tamponi (JObject s);
        void casi_testati (JObject s);
        void note_it (JObject s);
        void note_en (JObject s);
    }
}