using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz3
{
    internal class task4
    {
        interface IShape
        {
            double perimeter();
            double area();
        }

        class Triangle : IShape
        {
            public double a;
            public double b;
            public double c;

            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double area()
            {
                double hp = perimeter() / 2;
                return Math.Sqrt(hp*(hp-a)*(hp-b)*(hp-c));
            }

            public double perimeter()
            {
                return a + b + c;
            }
        }

        class Rectangle : IShape
        {
            public double a;
            public double b;

            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public double area()
            {
                return a * b;
            }

            public double perimeter()
            {
                return (a + b) * 2;
            }
        }

        class Trapezoid : IShape
        {
            public double a;
            public double b;
            public double c;
            public double d;
            public double h;

            public Trapezoid (double a, double b, double c, double d, double h)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.h = h;
            }

            public double area()
            {
                return (b + d) * h / 2;
            }

            public double perimeter()
            {
                return a + b + c + d;
            }
        }
    }
}
