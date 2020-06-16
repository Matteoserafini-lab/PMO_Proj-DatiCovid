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
        public void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Guariti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}