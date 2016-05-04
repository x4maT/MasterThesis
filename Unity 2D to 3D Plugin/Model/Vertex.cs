namespace Model
{
    public class Vertex
    {

        public const bool NORMAL_POINT_OUT = true;
        public const bool NORMAL_POINT_IN = false;

        public Point Position = null;
        public bool Normal = true;

        public Vertex() { }

        public Vertex(Point p, bool n)
        {
            this.Position = p;
            this.Normal = n;
        }

        public Vertex DeepCopy()
        {
            return new Vertex(this.Position.DeepCopy(), this.Normal);
        }

        public Vertex DeepCopyWith(float? PosX = null, float? PosY = null, float? PosZ = null, bool? normal = null)
        {
            Point p = this.Position.DeepCopy();
            bool n = this.Normal;

            if (PosX.HasValue)
                p.X = PosX.Value;

            if (PosY.HasValue)
                p.Y = PosX.Value;

            if (PosZ.HasValue)
                p.Z = PosX.Value;

            if (normal.HasValue)
                n = normal.Value;
            
            return new Vertex(p, n);
        }

    }
}