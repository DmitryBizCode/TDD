using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Rotate : IRotate
    {
        private (float X, float Y) Midle((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d)
        {
            float x = (a.X + b.X + c.X + d.X) / 4;
            float y = (a.Y + b.Y + c.Y + d.Y) / 4;
            return ( x,y);
        }
        private (float X, float Y) Midle((float X, float Y) a, (float X, float Y) b, (float X, float Y) c)
        {
            float x = (a.X + b.X + c.X) / 3;
            float y = (a.Y + b.Y + c.Y) / 3;
            return (x, y);
        }
        private (float X, float Y) Midle((float X, float Y) a, (float X, float Y) b)
        {
            float x = (a.X + b.X) / 2;
            float y = (a.Y + b.Y) / 2;
            return (x, y);
        }
        private void NewXY(ref (float X, float Y) a, in (float X, float Y) middle, int turn)
        {
            float x = (float)((a.X - middle.X) * Math.Cos(turn) - (a.Y - middle.Y) * Math.Sin(turn) + middle.X);
            float y = (float)((a.X - middle.X) * Math.Sin(turn) + (a.Y - middle.Y) * Math.Cos(turn) + middle.X);
            a.Y = y;
            a.X = x;
        }
        public void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, int turn)
        {
            (float X, float Y) middle = Midle(a,b,c,d);
            NewXY(ref a, middle, turn);
            NewXY(ref b, middle, turn);
            NewXY(ref c, middle, turn);
            NewXY(ref d, middle, turn);
        }
        public void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, int turn)
        {
            (float X, float Y) middle = Midle(a, b, c);
            NewXY(ref a, middle, turn);
            NewXY(ref b, middle, turn);
            NewXY(ref c, middle, turn);
        }
        public void RotateFigure(ref (float X, float Y) a, ref (float X, float Y) b, int turn)
        {
            (float X, float Y) middle = Midle(a, b);
            NewXY(ref a, middle, turn);
            NewXY(ref b, middle, turn);
        }
    }
}
