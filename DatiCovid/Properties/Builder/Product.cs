using System.Collections.Generic;

namespace DatiCovid
{    
    public class Product
    {
        internal string _name;
        
        private Dictionary<string, string> parts = new Dictionary<string, string>();
    
        public void Add(string s, string part){
            parts[s] = part;
        }

        public string GetData(){
            return parts["data"];
        }
        public string GetPart(Product p){
            return p.parts[this._name];
        }
        public Dictionary<string, string> GetParts()
        {
            return parts;
        }
    }
}