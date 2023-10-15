using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP
{
    internal class Square
    {
        //Math for how to calculate squares

        public float _area;
        public float _circumference;
        public float _volym;
        public int _hight;
        public int _lenght;

        public Square(int hight, int lenght)
        {
            _circumference = 2 * (hight + lenght);
            _area = hight * lenght;
        }
        public void GetArea()
        {
            Console.WriteLine(_area + " cm²");
        }

        public void GetCircumference()
        {
            Console.WriteLine(_circumference + " cm");
        }

        public void GetVolym()
        {
            Console.WriteLine(_volym + "cm³");

        }
    }
}
