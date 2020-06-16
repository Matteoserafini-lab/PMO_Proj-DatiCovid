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
        public void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new Deceduti(_O, ref lbRegioni, ref lbInfo2);
        }
        public void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2){
            ctx.CurrentState = new VarPositivi(_O, ref lbRegioni, ref lbInfo2);
        }
        public void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2)
        {
            ctx.CurrentState = new TotaleCasi(_O, ref lbRegioni, ref lbInfo2);
        }
    }
}