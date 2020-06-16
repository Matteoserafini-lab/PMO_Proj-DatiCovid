using System.IO;
using Gtk;

namespace DatiCovid
{
    class LoadProxy : ILoad
    {
        private bool b;
        private Load loader;

        public LoadProxy(ref Label lb, Liste l){
            this.b = true;
            if (File.Exists($"dati-ordinati/{l._name}.txt")){
                StreamReader sr1 = File.OpenText($"dati-ordinati/{l._name}.txt");
                    l.dati="";
                    while(!sr1.EndOfStream){
                        l.dati += $"{sr1.ReadLine()}\n";
                    }
                this.b = (lb.Text == l.dati) ? true : false;
            } else {
                lb.Text = ("Dati non presenti\naggiorna");
            }
        }
        private Load GetLoad(bool _b){
            this.loader = new Load(this.b);
            return this.loader; 
        }
        public void CaricaDati(ref Label lb, Liste l){
            this.GetLoad(this.b).CaricaDati(ref lb, l);
        }
    }
}