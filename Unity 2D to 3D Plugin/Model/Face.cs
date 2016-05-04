using System.Collections.Generic;

namespace Model
{
    public class Face
    {
        public const bool NORMAL_POINT_OUT = true;
        public const bool NORMAL_POINT_IN = false;

        public List<Vertex> Vertices = null;
        public bool Normal = true;

        public Face()
        {
        }

        public Face(bool normal, List<Vertex> vertices)
        {
            this.Normal = normal;
            this.Vertices = vertices;
        }

          
    }
}