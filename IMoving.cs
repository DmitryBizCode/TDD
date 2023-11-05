using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IMoving
    {
        void Move(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, in (float X, float Y) move);
        void Move(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, in (float X, float Y) move);
        void Move(ref (float X, float Y) a, ref (float X, float Y) b, in (float X, float Y) move);
    }
}
