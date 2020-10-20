using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SchreibTools
{
    public abstract class Stift
    { 
        public  int Strichstarke { get; set; }
        public  ConsoleColor Farbe { get; set; }
        public  string Typ { get; set; }

        public Stift(int strichstärke)
        {
          this.Strichstarke = strichstärke; // Strichstärke = 3
          this.Farbe = ConsoleColor.Black;
          this.Typ = "unbekannt";
           
        }
        public Stift(int strichstärke, ConsoleColor farbe) // : this (strichstärke)
        {
            this.Farbe = farbe;
            this.Strichstarke = strichstärke;
        }
        /*public string SchreibText( string text)
        {
            return $"{Typ},{Strichstarke}mm,{Farbe}";
        }
        */
        public void SchreibeText (string text)
        {
            
            Console.ForegroundColor = Farbe;
            Console.WriteLine($"{Typ}, {Strichstarke}mm, {text}");
            Console.ForegroundColor = Farbe;
            
        }
    }
}