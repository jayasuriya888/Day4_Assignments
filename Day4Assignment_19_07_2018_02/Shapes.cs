using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4Assignment_19_07_2018_02;
namespace Assignment2_17_07_2018
{
    
    class Shapes
    {
       

        [MethodInfoAttribute(MethodName = "area", Parameter = "double  pi, double  radius", ReturnType = "void",Message ="Finding the area of the circle")]
        public void area(double  pi, double  radius)
        {
            double area1;
            area1 = pi * radius * radius;
            Console.WriteLine("Area of the Circle = " + area1);
        }

        [MethodInfoAttribute(MethodName = "area", Parameter = "int length, int breadth", ReturnType = "void", Message = "Finding the area of the rectangle")]
        public void area(int length, int breadth)
        {
            int area1;
            area1 = length * breadth;
            Console.WriteLine("Area of the Rectangle = " + area1);
        }

        [MethodInfoAttribute(MethodName = "area", Parameter = "int side", ReturnType = "void", Message = "Finding the area of the square")]
        public void area(int side)
        {
            int area1;
            area1 = side * side;
            Console.WriteLine("Area of the Square = " + area1);
        }

        [MethodInfoAttribute(MethodName = "area", Parameter = "double cons,int b, int h", ReturnType = "void", Message = "Finding the area of the triangle")]
        public void area(double cons,int b, int h)
        {
            double area1;
            area1 = cons*b*h;
            Console.WriteLine("Area of the Triangle = " + area1);
        }

    }
}
