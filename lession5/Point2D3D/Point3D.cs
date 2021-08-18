namespace Point2D3D
{
    public class Point3D : Point2D
    {
        public float z { get; set; }

        public Point3D(float x, float y, float z) : base (x,y)
        {
            this.z = z;
        }

        public float[] GetXYZ()
        {
            float[] XYZ = {x,y,z};
            return XYZ;
        }

        public override string ToString()
        {
            return $"{base.ToString()} and {z}";
        }
    }
}