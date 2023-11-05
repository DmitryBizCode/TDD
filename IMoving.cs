using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IMoving
    {
        ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, in (float X, float Y) move);
        ((float X, float Y), (float X, float Y), (float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, in (float X, float Y) move);
        ((float X, float Y), (float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, in (float X, float Y) move);
    }
}
