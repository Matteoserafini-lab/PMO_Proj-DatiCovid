using Gtk;

namespace DatiCovid
{
    class TotaleCasi : DisplayState
    {
        private Officina _O;
        public TotaleCasi (Officina O, ref Label lbRegioni, ref Label lbInfo2){
            this._O = O;
            _O.StampaDati(ref lbRegioni, 2);
            lbInfo2.Text += "\nNext:\nVariazione Positivi\n\nPrevious:\nPositivi totali";
        }
        public void Next(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new TotaleCasi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Positivi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}