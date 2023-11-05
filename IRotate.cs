using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IRotate
    {
        ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, int turn);
        ((float X, float Y), (float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, int turn);
        ((float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, int turn);
    }
}
