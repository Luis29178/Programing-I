using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private Point x, y, z;
        private double ax, by, cz;
        public triangle(Point ax,Point by,Point cz)
        {
            x = ax;
            y = by;
            z = cz;
            ax = x.DistanceApart(y);
            by = y.DistanceApart(y);
            cz = z.DistanceApart(y);

        }
        public Point GetX()
        {
            return x;

        }
        public Point GetY()
        {
            return y;

        }
        public Point GetZ()
        {
            return z;

        }

        public void setX(Point p)
        {
            x = p;
            ax = x.DistanceApart(y);
            cz = z.DistanceApart(x);

        }
        public void setY(Point p)
        {
            y = p;
            ax = x.DistanceApart(y);
            by = y.DistanceApart(z);
            
        }
        public void setZ(Point p)
        {
            z = p;
            by = y.DistanceApart(y);
            cz = z.DistanceApart(x);
        }
        public double GetA()
        {
            return ax;
        }
        public double GetB()
        {
            return by;
        }
        public double GetC()
        {
            return cz;
        }

        public double Perimeter()
        {
            return ax + by = cz;
        }
        public double area()
        {
            double s = Perimeter();

            double triArea = Math.Sqrt((s - ax)*(s - by)*(s - cz));
            return triArea;
        }
    }
}
