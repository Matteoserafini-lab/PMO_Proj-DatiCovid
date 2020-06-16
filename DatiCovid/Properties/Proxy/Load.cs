using Gtk;

namespace DatiCovid
{
    class Load : ILoad
    {
        private bool _b = false;
        public Load(bool b){
            this._b = b;
        }
        public void CaricaDati(ref Label lb, Liste l){
            if (this._b == false){
                lb.Text = l.dati;
            }
        }
    }
}