//Josefin Mikaelsson .Net23
using Labb_5___OOP.MathBook;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Labb_5___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            //Run start page
            int userInputForm = MainePage.Meny();


            //to be abel to turn page whitout need to go back everytime. So is every page in a whileloop.
            while (true)
            {

                if (userInputForm == 1)
                {
                    Console.Clear();
                    userInputForm= CircualPage.CircelAndSphers();

                }
                else if (userInputForm == 2)
                {
                    Console.Clear();
                    userInputForm=TriangelPage.TriagelsAndPrisma();
                }
                else if (userInputForm == 3)
                {
                    Console.Clear();
                    userInputForm=SquarePage.SquareAndBox();

                }
                else if (userInputForm == 4)
                {
                    Console.Clear();
                    userInputForm=Answers.QusetionsAnswers();
                }
                else
                {
                    Console.Clear();
                    userInputForm = MainePage.Meny();
                    
                }
                
            }
        }

       
    }
} 

   
