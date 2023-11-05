using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Arrow : Point ,IArrow, IColorable
    {
        private string _colour;

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; } 
        }
        public Arrow((float X, float Y) a, (float X, float Y) b, string colour) : base(a, b)
        {
            if (a.X == b.X && a.Y == b.Y)
                throw new ArgumentOutOfRangeException("a.X == b.X && a.Y == b.Y");
            Colour = colour;
        }
        public float Length((float X, float Y) a, (float X, float Y) b) => (float)(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));
    }
}
