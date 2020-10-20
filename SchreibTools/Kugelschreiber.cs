using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SchreibTools
{
     public class Kugelschreiber : Stift
    {
       
        public Kugelschreiber(int strichstärke ,ConsoleColor farbe) : base(strichstärke,farbe)
        {
           this.Typ = "Kugelschreiber";
            this.Strichstarke = strichstärke;
            this.Farbe = farbe;
        }
        /*  public new virtual void SchreibText()
           {
               Console.WriteLine( $"{Typ},{Strichstarke}mm,{Farbe} " + "Hallo 3CHIT");

           }
        */
       /* public string SchreibText(string text)
        {
            return $"{Typ},{Strichstarke}mm,{Farbe}";
            
        }
       */

    }
}
