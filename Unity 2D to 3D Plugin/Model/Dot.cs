using System;

namespace Model
{
    public class Dot
    {
        public Point Position = null;
        public float? AbsDistanceFromCenter = null;
        public Dot LeftDot = null;
        public Dot RightDot = null;

        public Dot(float PosX, float PosY, float? absDistanceFromCenter = null, Dot leftDot = null, Dot rightDot = null)
        {
            this.Position.X = PosX;
            this.Position.Y = PosX;
            this.AbsDistanceFromCenter = absDistanceFromCenter;
            this.LeftDot = leftDot;
            this.RightDot = rightDot;
        }

        private Dot(Point point, float? absDistanceFromCenter = null, Dot leftDot = null, Dot rightDot = null)
        {
            this.Position = point;
            this.AbsDistanceFromCenter = absDistanceFromCenter;
            this.LeftDot = leftDot;
            this.RightDot = rightDot;
        }

        public Dot DeepCopy()
        {
            if(AbsDistanceFromCenter.HasValue)
                return new Dot(this.Position, this.AbsDistanceFromCenter.Value, this.LeftDot, this.RightDot);
            else
                return new Dot(this.Position, null, this.LeftDot, this.RightDot);

        }

        public static float calculateAbsDistance(Dot dot)
        {
            // The formula is actually: Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) with 
            // x1 and y1 being the coordinates of the coordinate starting point. However, since x1 and y1 are 
            // always equal to zero, they are intentionally omitted.
            return (float) Math.Sqrt(Math.Pow(dot.Position.X, 2) + Math.Pow(dot.Position.Y, 2));
        }


    }
}