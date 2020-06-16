using Newtonsoft.Json.Linq;
namespace DatiCovid
{
    class ConcreteBuilder : IBuilder
    {
        private Product product;
        public ConcreteBuilder() {
            this.Reset();
        }
        private void Reset() {
            product = new Product();
        }

        public void  data(JObject item) {
            string s = "data";
            product.Add(s, item.GetValue(s).ToString());
        }
        public void  stato(JObject item) {
            string s = "stato";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  codice_regione (JObject item) {
            string s = "codice_regione";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  denominazione_regione (JObject item) {
            string s = "denominazione_regione";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  codice_provincia (JObject item) {
            string s = "codice_provincia";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  denominazione_provincia (JObject item) {
            string s = "denominazione_provincia";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void sigla_provincia (JObject item) {
            string s = "sigla_provincia";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  latitutine (JObject item) {
            string s = "lat";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  longitudine (JObject item) {
            string s = "long";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  ricoverati_con_sintomi (JObject item) {
            string s = "ricoverati_con_sintomi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  terapia_intensiva (JObject item) {
            string s = "terapia_intensiva";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  totale_ospedalizzati (JObject item) {
            string s = "totale_ospedalizzati";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  isolamento_domiciliare (JObject item) {
            string s = "isolamento_domiciliare";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  totale_positivi (JObject item) {
            string s = "totale_positivi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  variazione_totale_positivi (JObject item) {
            string s = "variazione_totale_positivi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  nuovi_positivi (JObject item) {
            string s = "nuovi_positivi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  dimessi_guariti (JObject item) {
            string s = "dimessi_guariti";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  deceduti (JObject item) {
            string s = "deceduti";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  totale_casi (JObject item) {
            string s = "totale_casi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  tamponi (JObject item) {
            string s = "tamponi";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  casi_testati (JObject item) {
            string s = "casi_testati";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  note_it (JObject item) {
            string s = "note_it";
            product.Add(s,item.GetValue(s).ToString());
        }
        public void  note_en (JObject item) {
            string s = "note_en";
            product.Add(s,item.GetValue(s).ToString());
        }

        public Product GetProduct() {
            Product result = product;
            this.Reset();
            return result;
        }
    }
}