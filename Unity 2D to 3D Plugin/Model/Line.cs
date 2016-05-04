using System;
using System.Collections.Generic;

namespace Model
{
    public class Line
    {
        public bool isCurved = false;
        public List<Dot> Dots = null;
        private Point focalPoint = null;

        public Point FocalPoint
        {
            get
            {
                return this.focalPoint;
            }

            set
            {
                if (isCurved)
                    focalPoint = value;
                else
                    throw new Exception("You are trying to set a focal point to a line that is not curved." +
                        "A focal point can only be set to curved lines.");
            }
        }

        public bool IsCurved
        {
            get { return isCurved; }

            set
            {
                if(value)
                    throw new Exception("Curved lines are not supported yet.");
            }
        }

    }
}