using Gtk;

namespace DatiCovid
{
    class Guariti : DisplayState
    {
        private Officina _O;
        public Guariti (Officina O, ref Label lbRegioni, ref Label lbInfo2){
            this._O = O;
            _O.StampaDati(ref lbRegioni, 4);
            lbInfo2.Text += "\nNext:\nTotale Positivi\n\nPrevious:\nTotale Deceduti";
        }
        public void Next(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Positivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Guariti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2)
        {
            dch.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}