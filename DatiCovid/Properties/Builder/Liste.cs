using System.Linq;
using System.Collections.Generic;
using System;
using System.IO;

namespace DatiCovid
{    
    public class Liste : Product
    {
        public string dati{get;set;}
        public Liste(string name){
            this._name = name;
        }
        public Dictionary<string,string> dictionary = new Dictionary<string, string>();
        
        public void Order(){
            int counter = 0;
            string S = $"{this._name}:\n";
            if(S == "Italia:\n"){
                foreach (KeyValuePair<string, string> item in this.dictionary) {
                    S += ($"\t{item.Key} : {item.Value},\n");
                }
            } else {
                foreach (KeyValuePair<string, string> item in this.dictionary.OrderBy(key => Convert.ToInt32(key.Value))) {
                    counter++;
                    S += ($"{counter}_\t{item.Key} : {item.Value},\n");
                }
            }
            Directory.CreateDirectory("dati-ordinati");
            File.WriteAllText($"dati-ordinati/{this._name}.txt", S);
        }
    }
}