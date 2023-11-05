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
            return (x,y);
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
        private (float X, float Y) NewXY((float X, float Y) a, in (float X, float Y) middle, int turn)
        {
            float arg = (float)(turn * Math.PI / 180);
            float x = (float)(Math.Round((a.X - middle.X) * Math.Cos(arg) - (a.Y - middle.Y) * Math.Sin(arg) + middle.X, 2));
            float y = (float)(Math.Round((a.X - middle.X) * Math.Sin(arg) + (a.Y - middle.Y) * Math.Cos(arg) + middle.Y, 2));
            return (x, y);
        }
        public ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, int turn)
        {
            (float X, float Y) middle = Midle(a,b,c,d);
            (float X, float Y) newA = NewXY(a, middle, turn);
            (float X, float Y) newB = NewXY(b, middle, turn);
            (float X, float Y) newC = NewXY(c, middle, turn);
            (float X, float Y) newD = NewXY(d, middle, turn);
            return (newA, newB, newC, newD);
        }
        public ((float X, float Y), (float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, int turn)
        {
            (float X, float Y) middle = Midle(a, b, c);
            (float X, float Y) newA = NewXY(a, middle, turn);
            (float X, float Y) newB = NewXY(b, middle, turn);
            (float X, float Y) newC = NewXY(c, middle, turn);
            return (newA, newB, newC);
        }
        public ((float X, float Y), (float X, float Y)) RotateFigure((float X, float Y) a, (float X, float Y) b, int turn)
        {
            (float X, float Y) middle = Midle(a, b);
            (float X, float Y) newA = NewXY(a, middle, turn);
            (float X, float Y) newB = NewXY(b, middle, turn);
            return (newA, newB);
        }
    }
}
