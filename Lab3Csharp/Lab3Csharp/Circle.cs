using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Csharp
{
    public class Circle
    {
        double diameter;
        Point center;
       
        string name;
        public double GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter(double diameter)
        {
            if (diameter < 0)
                Console.WriteLine("Inga negativa tal");
            else
                this.diameter = diameter;
        }
        public double GetCircumference()
        {
            return diameter * Math.PI;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public Point GetCenter()
        {
            return center;
        }
        public void SetCenter(Point point)
        {
            if(point != null)
            center = point;
        }
    }
}
