using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP.MathBook
{
    internal static class Answers
    {
        public static int QusetionsAnswers()
        {
            Console.Clear();
            Console.WriteLine("" +
                "\nFACIT" +
                "\n+*+*+*+*+*+*+*+*+*+*+*+*+*+" +
                "\n");

            //Get answers from Class circel
            //area
            Console.WriteLine("Cirklar och sfärer:");

            Circel circelArea1 = new Circel(5); //radius 5
            Console.Write("1. ");
            circelArea1.GetArea();

            Circel circelArea2 = new Circel(6); //radius 6
            Console.Write("2. ");
            circelArea2.GetArea();


            //Cirumference
            Circel circelcircumference3 = new Circel(6); //radius 6
            Console.Write("3. ");
            circelcircumference3.GetCircumference();

            Circel circelcircumference4 = new Circel(2); //radius 2
            Console.Write("4. ");
            circelcircumference4.GetCircumference();

            //volym
            Circel circelVolym5 = new Circel(5); //radius 5
            Console.Write("5. ");
            circelVolym5.GetVolym();


            Console.WriteLine("");


            //Get answers from class Triangeel
            Console.WriteLine("Trianglar och prismor");

            Triangel triangelArea1 = new Triangel(8, 6, 0,0);//base 8 and hight 6
            Console.Write("1. ");
            triangelArea1.GetArea();

            Triangel triangelArea2 = new Triangel(6, 4, 0, 0); //base 6 and hight 4
            Console.Write("2. ");
            triangelArea2.GetArea();

            Triangel triangelCircumference3 = new Triangel(7, 0, 9, 12);
            Console.Write("3. ");
            triangelCircumference3.GetCircumference();


            Console.WriteLine("");


            //Get answers from class Square
            Console.WriteLine("Rektanglar och boxar");

            Square squareArea1 = new Square(10, 6);
            Console.Write("1. ");
            squareArea1.GetArea();

            Square squareArea2 = new Square(8,4);
            Console.Write("2. ");
            squareArea2.GetArea();

            Square squareCircumference3 = new Square(4, 2);
            Console.Write("3. ");
            squareCircumference3.GetCircumference();






            //turn page
            Console.WriteLine("" +
            "\n*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*" +
            "\n<--[3] Förgående sida" +
            "\n[0] Förstasidan");
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput >= 0 && userInput <= 4)
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
