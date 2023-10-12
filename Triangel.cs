using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP
{
    internal class Triangel
    {
        public float _area;
        public float _circumference;
        public float _volym;
        public int _base;
        public int _hight;

        public Triangel(int triangelBase, int triangelHight)
        {
            _area = (triangelBase * triangelHight) / 2;
            //_circumference = ;
            //_volym = ;


        }

        public void GetArea()
        {
            Console.WriteLine(_area + " cm²");
        }

        //public void GetCircumference()
        //{
        //    Console.WriteLine(_circumference + " cm");
        //}

        //public void GetVolym()
        //{
        //    Console.WriteLine(_volym + "cm³");
        //}

    }


}
