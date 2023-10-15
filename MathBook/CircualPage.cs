using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP.MathBook
{
    internal static class CircualPage
    {
        public static int CircelAndSphers()
        {

            //Questions, calulate area
            Console.WriteLine("Cirklar och sfärer" +
                "\n" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                               +" +
                "\n*     För att räkna ut arean på en cirkel använder du formeln:                  *" +
                "\n+     A = π * r^2                                                               +" +
                "\n*     Där A är arean, π (pi) är en konstant ungefär lika med 3,141,             *" +
                "\n+     och r är radien (avståndet från cirkelns mitt till dess kant).            +" +
                "\n*     Du multiplicerar pi med radien i kvadrat (r²) för att få cirkelns area.   *" +
                "\n+                                                                               +" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n");

            Console.WriteLine("Uppgift 1. En cirkel har radien 4 cm?" +
                "\n           Beräkna cirkelns area. Svara med 3 decimaler." +
                "\n" +
                "\nUppgift 2. Vilken area har en cirkel som har en diameter på på 12 cm?" +
                "\n" +
                "\n");

            //Questions, calculate perimeter
            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n+                                                                               +" +
                "\n*     Omkretsen(C) av en cirkel beräknas med formeln:                           *" +
                "\n+     C = 2πr                                                                   +" +
                "\n*     Där är C är omkretsen och r är radien                                     *" +
                "\n+     Du multiplicerar radien med 2π för att få cirkelns omkrets.               +" +
                "\n*                                                                               *" +
                "\n+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+" +
                "\n");

            Console.WriteLine("Uppgift 3. Vilken omkrets har en cirkel med en radie på 6 cm?" +
                "\n" +
                "\n" +
                "\nUppgift 4. Om en cirkel har en diameter på 4 cm." +
                "\n           Vad blir cirkelns omkrets?" +
            "\n");


            //Qusetions, claculate volym
            Console.WriteLine("" +
              "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
              "\n+                                                                               +" +
              "\n*     Volymen (V) av en cirkel beräknas med formeln:                            *" +
              "\n+     V = (4π*r³)/3                                                             +" +
              "\n*     Där är V är volymen och r är radien                                       *" +
              "\n+                                                                               +" +
              "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
              "\n");
            Console.WriteLine("Uppgift 1. En sfär har en radie på 5 centimeter.Beräkna volymen av sfären." +
                "\n");

            //Turn pagie
            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n<--[0] Förgånede sida | Nästa sida [2]-->");

            Program math = new Program();
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput >= 0 && userInput <=4)
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
