using System;

namespace Point2D3D
{
    public class Point2D
    {
        protected float x { get; set; }
        protected float y { get; set; }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            float [] array = {x,y};
            return array;
        }

        public override string ToString()
        {
            return $"{x} and {y}";
        }
    }
}