//Josefin Mikaelsson .Net23
using System.Security.Cryptography.X509Certificates;

namespace Labb_5___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Matematik 3000" +
            "\n" +
            "\nKapitel 1" +
            "\nGeometri" +
            "\n*+*+*+*+*+*+*+*+*+*+*+*+*" +
            "\nVilken sida vill öppna?" +
            "\n[1] Cirklar / Sfvärer" +
            "\n[2] Trianglar /Prismor" +
            "\n[3] Fyrkanter / Boxar" +
            "\n[4] Facit");
            while (true)
            {
                int userInputForm = int.Parse(Console.ReadLine());

                Program math = new Program();
                if (userInputForm == 1)
                {
                    Console.Clear();
                    math.CircelAndSphers();

                }
                else if (userInputForm == 2)
                {
                    Console.Clear();
                    math.TriagelsAndPrisma();
                }
                else if (userInputForm == 3)
                {
                    Console.Clear();
                    math.SquareAndBox();

                }
                else if (userInputForm == 4)
                {
                    Console.Clear();
                    math.Answers();
                }
                else
                {
                    Console.WriteLine("Välj sida [1] eller [2] eller [3] eller [4]");
                }
            }
        }

        public void CircelAndSphers()
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
                "\n*     är C är omkretsen, D, och r är radien                                     *" +
                "\n+     Du multiplicerar radien med 2π för att få cirkelns omkrets.               +" +
                "\n*                                                                               *" +
                "\n+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+" +
                "\n");

            Console.WriteLine("Uppgift 3. Vilken omkrets har en cirkle med en radie på 6 cm?" +
                "\n" +
                "\n" +
                "\nUppgift 4. Om en cirkle har en diameter på 4 cm." +
                "\n           Vad blir cirkelns omrkets?" +
                "\n");

            //Turn pagie
            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n<--[0] Förgånde sida | Nästa sida [2]-->");

            Program math = new Program();
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    math.TriagelsAndPrisma();
                }
                else
                {
                    Console.WriteLine("Välj 0 eller 2");
                }
            }
            Console.Clear();
            return;
        }


        public void TriagelsAndPrisma()
        {
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
                "\n           Beräkna triangelns area." +
                "\n");

            Console.WriteLine("" +
                "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
                "\n<--[1] Förgånde sida | Nästa sida [3]-->");
            Program math = new Program();
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.Clear();
                    math.CircelAndSphers();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    math.SquareAndBox();
                }
                else

                {
                    Console.WriteLine("Välj 1 eller 3");
                }
            }
        }

        public void SquareAndBox()
        {
            Console.WriteLine("OJ! Här var de tomt!" +
            "\nUppgifter kommer...");

            Console.WriteLine("" +
             "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
             "\n<--[2] Förgånde sida | Nästa sida [4]-->");
            Program math = new Program();
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 2)
                {
                    Console.Clear();
                    math.TriagelsAndPrisma();
                }
                else if (userInput == 4)
                {
                    Console.Clear();
                    math.Answers();
                }
                else
                {
                    Console.WriteLine("Välj 2 eller 4");
                }
            }
        }


        public void Answers()
        {
            Console.Clear();
            Console.WriteLine("" +
                "\nFACIT" +
                "\n+*+*+*+*+*+*+*+*+*+*+*+*+*+" +
                "\n");
            //Get answers from Class circel and method area
            Console.WriteLine("Cirklar och sfärer:");

            Circel circelArea5 = new Circel(5); //radius 5
            Console.Write("1. ");
            circelArea5.GetArea();

            Circel circelArea6 = new Circel(6); //radius 6
            Console.Write("2. ");
            circelArea6.GetArea();


            //Get answers from Class circel and method circelcircumference
            Circel circelcircumference6 = new Circel(6); //radius 6
            Console.Write("3. ");
            circelcircumference6.GetCircumference();

            Circel circelcircumference2 = new Circel(2); //radius 2
            Console.Write("4. ");
            circelcircumference6.GetCircumference();

            Console.WriteLine("");

            //Get answers from class Triangeel and method area
            Console.WriteLine("Trianglar och prismor");

            Triangel triangelArea86 = new Triangel(8, 6);
            Console.Write("1. ");
            triangelArea86.GetArea();

            Triangel triangelArea64 = new Triangel(6, 4);
            Console.Write("2. ");
            triangelArea64.GetArea();



            Console.WriteLine("" +
            "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
            "\n<--[3] Förgånde sida" +
            "\n[0] Förstasidan");
            Program math = new Program();
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 3)
                {
                    Console.Clear();
                    math.SquareAndBox();
                }
                else if (userInput == 0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Välj 3 eller 0");
                }
            }
        }


    }
} 

   
