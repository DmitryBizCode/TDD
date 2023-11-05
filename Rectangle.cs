using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Rectangle : Point , IRectangle , IColorable
    {
        public string Colour { get; set; }
        public Rectangle((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, string colour) : base(a, b, c, d)
        {
            float q = Length(A, B);
            float w = Length(B, C);
            float e = Length(C, D);
            float r = Length(D, A);
            if (q == w || q != e || w != r || e == r || q == r || w == e)
                throw new ArgumentOutOfRangeException("a == b || a != c || b != d || c == d || a == d || b == c");
            Colour = colour;
        }
        public float Length((float X, float Y) a, (float X, float Y) b) => (float)(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));
        public float S()
        {
            float a = Length(A, B);
            float b = Length(B, C);
            return a * b;
        }
        public float P()
        {
            float a = Length(A, B);
            float b = Length(B, C);
            return 2 * (a + b);
        }
    }
}
