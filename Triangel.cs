﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___OOP
{
    internal class Triangel
    {
        //Math for calculate triangels

        public float _area;
        public float _circumference;
        public float _volym;
        public int _base;
        public int _hight;
        public int _side1;
        public int _side2;

        public Triangel(int triangelBase, int triangelHight, int side1, int side2)
        {
            _area = (triangelBase * triangelHight) / 2;
             _circumference = triangelBase + _side1 + side1; 
            //_volym = ;
        }
        

        public void GetArea()
        {
            Console.WriteLine(_area + " cm²");
        }
        public void GetCircumference()
        {
            Console.WriteLine(_circumference + " cm");
        }

       

        //public void GetVolym()
        //{
        //    Console.WriteLine(_volym + "cm³");
        //}




    }


}
