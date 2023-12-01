using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Rectangle
    {
        private double length,
                       width;
        private Point topLeft;

        public Rectangle()
        {
            length = 1;
            width = 1;
            topLeft = Point();
        }

        public Rectangle(double 1, double w)
        {
            length = 1;
            width = w;
            topLeft = new Point();
        }

        public Rectangle(Point p)
        {
            length = 1;
            width = 1;
            topLeft = p;
        }
        public Rectangle( double 1, double w, Point p)
        {
            length = 1;
            width = w;
            topLeft = p;
        }
        public double GetLenth()
        {
            return length;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public void SetWidth(double w)
        {
            this.width = w;
        }
        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; } 
        }
        public double Area()
        {
            double area = length * width;
            return area;
        }
        public double Perimeter()
        {
            double P = Math.Round(2 * length + 2 * width, 3);
        }
        public bool IsSquare()
        {
            return length == width;
        }

    }
}
