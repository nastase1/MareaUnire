using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareaUnire.Model {

    public class Intrebare {
        // Create properties for the class: intrebare, raspuns1, raspuns2, raspuns3, raspuns4, raspunsCorect
        public string Text { get; set; }
        public string Raspuns1 { get; set; }
        public string Raspuns2 { get; set; }
        public string Raspuns3 { get; set; }
        public string Raspuns4 { get; set; }
        public string RaspunsCorect { get; set; }

        // Create a constructor for the class
        public Intrebare(string text, string raspuns1, string raspuns2, string raspuns3, string raspuns4, string raspunsCorect) {
            this.Text = text;
            this.Raspuns1 = raspuns1;
            this.Raspuns2 = raspuns2;
            this.Raspuns3 = raspuns3;
            this.Raspuns4 = raspuns4;
            this.RaspunsCorect = raspunsCorect;
        }

        // Create a method that returs the array of answers
        public string[] GetRaspunsuri() {
            string[] raspunsuri = new string[4];
            raspunsuri[0] = this.Raspuns1;
            raspunsuri[1] = this.Raspuns2;
            raspunsuri[2] = this.Raspuns3;
            raspunsuri[3] = this.Raspuns4;
            return raspunsuri;
        }

        // Create a method that returns the correct answer
        public string GetRaspunsCorect() {
            return this.RaspunsCorect;
        }
    }
}
