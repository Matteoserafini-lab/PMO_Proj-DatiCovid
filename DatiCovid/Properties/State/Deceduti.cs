using Gtk;

namespace DatiCovid
{
    class Deceduti : DisplayState
    {
        private Officina _O;
        public Deceduti (Officina O, ref Label lbRegioni, ref Label lbInfo2){
            this._O = O;
            _O.StampaDati(ref lbRegioni, 5);
            lbInfo2.Text += "\nNext:\nGuariti\n\nPrevious:\nVariazione Positivi";
        }
        public void Next(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Guariti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}