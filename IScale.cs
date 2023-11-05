using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IScale
    {
        void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, int scale);
        void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, int scale);
        void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, int scale);
    }
}
