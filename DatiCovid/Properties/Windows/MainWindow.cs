using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace DatiCovid
{
    class MainWindow : Window
    {
        [UI] private Label lbInfo1 = null;
        [UI] private Label lbItalia = null;
        [UI] public Label lbRegioni = null;
        [UI] private Label lbInfo2 = null; 
        [UI] private Button _button1 = null;
        [UI] private Button _button2 = null;
        [UI] private Button _button3 = null;
        private readonly string info = "\nnuovi dati ogni giorno\n dopo le 17:00";
        private DisplayContext ctx;

        public MainWindow() : this(new Builder("MainWindow.glade")) {
            this.lbInfo1.Text = $"{DateTime.Now} {this.info}"; 
            this.ctx = new DisplayContext(ref lbItalia, ref lbRegioni, ref lbInfo2);
            ctx.Update(ref lbItalia, ref lbRegioni, ref lbInfo2);
        }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
            _button2.Clicked += Button2_Clicked;
            _button3.Clicked += Button3_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            ctx.Previous(ref lbRegioni, ref lbInfo2);
            this.lbInfo1.Text = $"{DateTime.Now} {this.info}";
        }

        private void Button2_Clicked(object sender, EventArgs a){
            this.lbInfo1.Text = $"{DateTime.Now} {this.info}";
            ctx.Update(ref lbItalia, ref lbRegioni, ref lbInfo2);
        }
        
        private void Button3_Clicked(object sender, EventArgs a)
        {
            ctx.Next(ref lbRegioni, ref lbInfo2);
            this.lbInfo1.Text = $"{DateTime.Now} {this.info}";
        }
    }
}