using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP.MathBook
{
    internal static class TriangelPage
    {
        public static int TriagelsAndPrisma()
        {
            //Qusestions, calculate area
            Console.WriteLine("Trianglar och Prismor" +
                "\n" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                                             *" +
                "\n* För att räkna ut arean av en triangel använder du följande formel:                          +" +
                "\n+ A = (bas * höjd) / 2                                                                        *" +
                "\n* Där A är arean, bas är längden på triangelns bas,                                           +" +
                "\n+ och höjd är höjden från basen till det motsatta hörnet.                                     +" +
                "\n* Multiplicera basen med höjden och dela sedan resultatet med 2 för att få triangelns area.   *" +
                "\n+                                                                                             +" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n");

            Console.WriteLine("Uppgift 1. En triangel har en bas som mäter 8 centimeter och en höjd på 6 centimeter." +
                "\n           Beräkna triangelns area." +
                "\n" +
                "\nUppgift 2. En rätvinklig triangel har en bas som mäter 6 centimeter och en höjd som mäter 4 centimeter." +
                "\n           Beräkna triangelns area.");

            Console.WriteLine(""+
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                                             *" +
                "\n* För att räkna ut omkretsen av en triangel adderas längden på alla dess tre sidor.           +" +
                "\n+ Du använder följande formel:                                                                *" +
                "\n* P = a + b + c                                                                               +" +
                "\n+ Där P är omkretsen och a, b, och c är triangelns sidor                                      +" +
                "\n+                                                                                             +" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n");

            Console.WriteLine("Uppgift 3. En triangel har sidor med längderna a = 7 cm, b = 9 cm och c = 12 cm." +
                "\n           Beräkna triangelns omkrets.");


            //Turn page
            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n<--[1] Förgående sida | Nästa sida [3]-->");
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput >= 0 && userInput <= 4)
                {
                    Console.Clear();
                    return(userInput);
                }
                else

                {
                    Console.WriteLine("Boken har bara 4 sidor...");
                }
            }
        }
    }
}
