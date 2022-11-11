using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Geometrie
{
    internal class program
    {
        static void Main(string[] args)
        {
            point p = new point(10, 2);

        }
        public class point
        {
            private float x, y;
            public void setY(float p)
            {
                y = p;
            }
            public void setX(float p)
            {
                x = p;
            }
            public float getY()
            {
                return y;
            }
            public float getX()
            {
                return x;
            }
            public point(float b, float c)
            {
                x = b;
                y = c;
            }
            public bool equal(point p)
            {
                if (this.x == p.x && this.y == p.y)
                    return true;
                else
                    return false;
            }
            public float distance(point p)
            {
                float dx = this.x - p.x;
                float dy = this.y = p.y;
                return (float)Math.Sqrt(dx * dx + dy * dy);
            }
            public void translation(float p)
            {
                x += p;
                y += p;

            }
            public void rotation(float a)
            {
                x = (float)(x * Math.Cos(a) - y * Math.Sin(a));
                y = (float)(x * Math.Cos(a) - y * Math.Sin(a));
            }
        }
    }
}
