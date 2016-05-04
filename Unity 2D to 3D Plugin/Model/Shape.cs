using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Shape
    {
        public List<Dot> DotsList = null;
        public List<Line> LinesList = null;

        public Shape() { }

        public Shape(List<Dot> dots, List<Line> lines)
        {
            this.DotsList = dots;
            this.LinesList = lines;
        }
    }
}
