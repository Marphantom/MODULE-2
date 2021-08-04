using System;

namespace rectangle
{

    public class Rectangle
    {
        double width, height;

        public Rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getArea()
        {
            return width*height;
        }

        public double getPrimeter()
        {
            return (width + height)* 2;
        }

        public string display()
        {
            return ($"Width: {width} and Height: {height}");
        }

    }
}
