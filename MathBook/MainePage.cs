using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP.MathBook
{
    internal static class MainePage
    {

        public static int Meny()
        { 
           Console.WriteLine( "Matematik 3000" +
           "\n" +
           "\nKapitel 1" +
           "\nGeometri" +
           "\n*+*+*+*+*+*+*+*+*+*+*+*+*" +
           "\nVilken sida vill öppna?" +
           "\n[1] Cirklar / Sfärer" +
           "\n[2] Trianglar /Prismor" +
           "\n[3] Fyrkanter / Boxar" +
           "\n[4] Facit");

            int userInput = int.Parse(Console.ReadLine());
            return userInput;

        }
    }
}
