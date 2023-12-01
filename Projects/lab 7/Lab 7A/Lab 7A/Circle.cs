using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_7A
{

    public class Circle
    {
        private float Xpos;
        private float Ypos;
        private float Radious;

        
        

        public  Circle(float mXpos, float mYpos, float mRadious)
        {
            Xpos = mXpos;
            Ypos = mYpos;
            Radious = mRadious;

        }
        public float GetX()
        {
            return Xpos;
        }
        public float GetY()
        {
            return Ypos;
        }
        public float GetRadius()
        {
            return Radious;
        }
        public float GetArea()
        {
           float Area = (float)Math.PI * (float)Math.Pow(Radious, 2);
            return Area;
        }
        public float GetCircumference()
        {
           float Circon = (float)Math.PI * 2 * Radious;
            return Circon;
        }
        public bool Contains(float px, float py)
        {
            bool ans = true;           
            float distance = (float)Math.Sqrt(Math.Pow((px + Xpos), 2) + Math.Pow((py + Ypos), 2));
            if(distance > Radious)
            {
                ans = false;
            }
            return ans;
        }


    }

}
