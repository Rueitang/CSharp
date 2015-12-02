using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Line
    {
        public Point startPoint;
        public Point endPoint;

        public double GetY(double x)
        {
            double slope = (endPoint.y - startPoint.y) / (endPoint.x - startPoint.x);
            double y = slope * (x - startPoint.x) + startPoint.y;
            return y;
        }
    }
}