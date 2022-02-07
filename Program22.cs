using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    public class Circle
    {
        int radius;
        double pi = 3.14, area;
        double area = pi * radius * radius;
    }
        public class Cylinder
        {
            int height = 38;
            int radius = 35;
            double pie = 3.14285714286;
            double volume = pie * (radius * radius) * height;
        public Cylinder(double v)
        {
            this.volume = v;
            
        }
            
        }  
    class Program22
    {
        Circle[] circles = {
    new Cylinder(12.34),
    new Cylinder(12.34, 10.0),
    new Cylinder(12.34, 10.0, "blue")
};
    }

    }
}

