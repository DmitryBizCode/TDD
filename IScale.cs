using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IScale
    {
        ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, float scale);
        ((float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, float scale);
        ((float X, float Y), (float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, float scale);
    }
}
