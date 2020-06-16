using Gtk;

namespace DatiCovid
{
    class VarPositivi : DisplayState
    {
        private Officina _O;
        public VarPositivi (Officina O, ref Label lbRegioni, ref Label lbInfo2){
            this._O = O;
            _O.StampaDati(ref lbRegioni, 1);
            lbInfo2.Text += "\nNext:\nDeceduti\n\nPrevious:\nTotale Casi";
        }
        public void Next(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2){
            dch.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2)
        {
            dch.CurrentState = new TotaleCasi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}