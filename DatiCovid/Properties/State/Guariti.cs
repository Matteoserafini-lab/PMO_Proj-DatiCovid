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
        public void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Positivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Guariti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2)
        {
            ctx.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}