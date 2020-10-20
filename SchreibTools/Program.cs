using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchreibTools
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            List<Stift> s = new List<Stift>();


            Kugelschreiber k1 = new Kugelschreiber(5, ConsoleColor.Blue);
            s.Add(k1);
            k1.SchreibeText("Winter");
            Kugelschreiber k2 = new Kugelschreiber(3, ConsoleColor.Red);
            s.Add(k2);
            k2.SchreibeText("Herbst");

            Buntstift b1 = new Buntstift(4, ConsoleColor.DarkYellow);
            s.Add(b1);
            b1.SchreibeText("Frühling");

            Buntstift b2 = new Buntstift(5, ConsoleColor.DarkGray);
            s.Add(b2);
            b2.SchreibeText("Sommer");


            Console.ReadKey();



        }
    }
}
