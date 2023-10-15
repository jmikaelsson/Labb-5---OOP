using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP.MathBook
{
    internal static class SquarePage
    {
        public static int SquareAndBox()
        {
            Console.WriteLine("Rektanglar och Prismor" +
                "\n");


            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                                             *" +
                "\n* För att räkna ut arean av en rektangel multipliceras längden och höjden.                    +" +
                "\n+ Du använder följande formel:                                                                *" +
                "\n* A = x*y                                                                                     +" +
                "\n+ Där A är arean och x är rektangels höjd och y är längden.                                   +" +
                "\n+                                                                                             +" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n");

            Console.WriteLine("Uppgift 1. En rektangel har längden 10 centimeter och bredden 6 centimeter ."+
                "\n           Beräkna rektangelns area."+
                "\n"+
                "\nUppgift 2. En rektangel har längden 8 centimeter och bredden 4 centimeter."+
                "\n           Beräkna rektangelns area.");

            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                                             *" +
                "\n* För att räkna ut omkretsen av en rektangel multipliceras summan av längden och höjden.      +" +
                "\n+ Du använder följande formel:                                                                *" +
                "\n* P = 2+(a+b)                                                                                 +" +
                "\n+ Där P är omkretsen och a är rektangels höjd och b är längden.                               +" +
                "\n+                                                                                             +" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n");

            Console.WriteLine("Uppgift 3. En fyrkant har en längd på 4 cm och en höjd på 2 cm. Vad har den för omkrets?");


            //Turn page
            Console.WriteLine("" +
             "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
             "\n<--[2] Förgående sida | Nästa sida [4]-->");
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput >= 0 && userInput <=4)
                {
                    Console.Clear();
                    return (userInput);
                }
                else
                {
                    Console.WriteLine("Det finns bara 4 sidor..");
                }
            }
        }

    }
}
