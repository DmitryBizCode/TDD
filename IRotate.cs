using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IRotate
    {
        void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, int turn);
        void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, int turn);
        void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, int turn);
    }
}
