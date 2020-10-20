using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchreibTools
{
     class Buntstift : Stift
    {
       // public string Typ { get; set; }
        public Buntstift(int strichstärke, ConsoleColor farbe) :base(strichstärke,farbe)
        {
            this.Typ = "Buntstift";
            this.Strichstarke = strichstärke;
            this.Farbe = farbe;
        }
       /*public new virtual void SchreibText()
        {
            Console.WriteLine($"{Typ},{Strichstarke}mm,{Farbe} " + "Hallo 3CHIT");
        }
       */
    }

}
