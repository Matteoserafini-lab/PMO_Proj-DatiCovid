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
        public void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new TotaleCasi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Positivi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}