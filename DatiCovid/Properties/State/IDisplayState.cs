using Gtk;
using System.Collections.Generic;

namespace DatiCovid
{
    public interface DisplayState
    {
        void Next(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2);
        void UpdateState(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2);
        void Previous(DisplayContext ctx, ref Label lbRegioni, ref Label lbInfo2);
    }
}