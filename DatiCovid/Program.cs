using System;
using Gtk;
using System.IO;

namespace DatiCovid
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            try{
                Application.Init();
                
                var app = new Application("org.DatiCovid.DatiCovid", GLib.ApplicationFlags.None);
                app.Register(GLib.Cancellable.Current);
                
                var win = new MainWindow();
                app.AddWindow(win);
                
                win.Show();
                
                Application.Run();

            } catch (Exception) {
                Console.WriteLine("qualcosa è andato storto!");
            }
        }
    }
}
