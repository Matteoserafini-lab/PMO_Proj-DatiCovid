using Gtk;

namespace DatiCovid
{
    class Positivi : DisplayState
    {
        private Officina _O;
        public Positivi (Officina O, ref Label lbRegioni, ref Label lbInfo2){
            this._O = O;
            _O.StampaDati(ref lbRegioni, 3);
            lbInfo2.Text += "\nNext:\nTotale Casi\n\nPrevious:\nTotale Guariti"; 
        }
        public void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new TotaleCasi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Positivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Guariti(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}