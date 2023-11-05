using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Point : IDot
    {
        public Point((float X, float Y) a, (float X, float Y) b)
        {
            A = a; 
            B = b;
        }
        public Point((float X, float Y) a, (float X, float Y) b, (float X, float Y) c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Point((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public (float X, float Y) A { get; set; }
        public (float X, float Y) B { get; set; }
        public (float X, float Y) C { get; set; }
        public (float X, float Y) D { get; set; }

    }
}
