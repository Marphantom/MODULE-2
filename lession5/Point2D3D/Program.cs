using System;

namespace Point2D3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p2d = new Point2D (3,5);
            Point3D p3d = new Point3D (8,6,9);

            Console.WriteLine(p2d.ToString());
            Console.WriteLine(p3d.ToString());

            p3d = new Point3D (10,10,10);
            Console.WriteLine(p3d.ToString());
        }
    }
}
