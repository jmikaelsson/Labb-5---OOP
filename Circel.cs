using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP
{
    internal class Circel
    {
        public float _pi;
        public int _radius;
        public float _area;
        public float _circumference;
        public float _volym;

        public Circel(int radius)
        {
            _pi = 3.141f;
            _radius = radius;
            _area = radius*radius*_pi;
            _circumference = _pi * 2 * radius;
            _volym = (4 * _pi * (radius * radius * radius)) / 3;
        }
        public void GetArea()
        {
           Console.WriteLine(_area + " cm²");
        }

        public void GetCircumference()
        {
            Console.WriteLine(_circumference + " cm");
        }

        public void GetVolym ()
        {
            Console.WriteLine(_volym + "cm³");
            
        }
    }
}
