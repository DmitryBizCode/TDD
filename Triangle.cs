using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Triangle : Point,  ITriangle, IColorable
    {
        public string Colour { get; set; }
        public Triangle((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, string colour) : base(a, b, c)
        {

            float q = Length(A, B);
            float w = Length(B, C);
            float e = Length(C, D);
            if (((q + w) < e || (q + e) < w || (e + w) < q) || (a.X == b.X && a.X == c.X && b.X == c.X) ||
                (a.Y == b.Y && a.Y == c.Y && b.Y == c.Y))
                throw new ArgumentOutOfRangeException("((q + w) < e && (q + e) < w && (e + w) < q) || (a.X == b.X && a.X == c.X && b.X == c.X) || (a.Y == b.Y && a.Y == c.Y && b.Y == c.Y)");
            Colour = colour; 
        }

        public float Length((float X, float Y) a, (float X, float Y) b) => (float)(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));

        public float P()
        {
            float q = Length(A, B);
            float w = Length(B, C);
            float e = Length(C, D);
            return (float)(q + w + e);
        }
        public float S()
        {
            float q = Length(A, B);
            float w = Length(B, C);
            float e = Length(C, D);
            float p = P() / 2;
            return (float)Math.Sqrt(p*(p - q)*(p - w)*(p - e));
        }
    }
}
