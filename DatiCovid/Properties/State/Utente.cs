using Gtk;

namespace DatiCovid
{
    public class DisplayChoice
    {
        private Officina O;
        public DisplayChoice(ref Label lbItalia, ref Label lbRegioni, ref Label lbInfo2){
            this.O = new Officina();
            O.Aggiorna(ref lbItalia, ref lbInfo2);
            this.CurrentState = new VarPositivi(O, ref lbRegioni, ref lbInfo2); 
        }
        public DisplayState CurrentState { get; set; }
        public void Next(ref Label lbRegioni, ref Label lbInfo2){
            lbInfo2.Text = "";
            CurrentState.Next(this, ref lbRegioni, ref lbInfo2);
        }
        public void Update(ref Label lbItalia, ref Label lbRegioni, ref Label lbInfo2){
            this.O = new Officina();
            O.Aggiorna(ref lbItalia, ref lbInfo2);
            CurrentState.UpdateState(this, ref lbRegioni, ref lbInfo2);  
        }
        public void Previous(ref Label lbRegioni, ref Label lbInfo2){
            lbInfo2.Text = "";
            CurrentState.Previous(this, ref lbRegioni, ref lbInfo2);
        }
    }
}