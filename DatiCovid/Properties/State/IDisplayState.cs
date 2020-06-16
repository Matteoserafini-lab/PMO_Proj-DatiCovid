using Gtk;
using System.Collections.Generic;

namespace DatiCovid
{
    public interface DisplayState
    {
        void Next(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2);
        void UpdateState(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2);
        void Previous(DisplayChoice dch, ref Label lbRegioni, ref Label lbInfo2);
    }
}