using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Scale : IScale
    {
        public ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, float scale)
        {
            (float X, float Y) newA = (a.X - scale, a.Y - scale);
            (float X, float Y) newB = (b.X - scale, b.Y + scale);
            (float X, float Y) newC = (c.X + scale, c.Y + scale);
            (float X, float Y) newD = (d.X + scale, d.Y - scale);
            return (newA, newB, newC, newD);
        }
        public ((float X, float Y), (float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, float scale)
        {
            (float X, float Y) newA = (a.X - scale, a.Y - scale);
            (float X, float Y) newB = (b.X, b.Y + scale);
            (float X, float Y) newC = (c.X + scale, c.Y - scale);
            return (newA, newB, newC);

        }

        public ((float X, float Y), (float X, float Y)) Scaling((float X, float Y) a, (float X, float Y) b, float scale)
        {
            (float X, float Y) newA;
            (float X, float Y) newB;
            if (a.X == b.X)
            {
                if (a.Y > b.Y)
                {
                    newA = (a.X, a.Y + scale);
                    newB = (b.X, b.Y - scale);
                }
                else
                {
                    newA = (a.X, a.Y - scale);
                    newB = (b.X, b.Y + scale);
                }              
                                  
            }
            else if(a.X > b.X)
            {
                if(a.Y == b.Y)
                {
                    newA = (a.X + scale, a.Y);
                    newB = (b.X - scale, b.Y);
                }
                else if(a.Y > b.Y) {
                    newA = (a.X + scale, a.Y + scale);
                    newB = (b.X - scale, b.Y - scale);
                }
                else
                {
                    newA = (a.X + scale, a.Y - scale);
                    newB = (b.X - scale, b.Y + scale);
                }
            }
            else
            {
                if (a.Y == b.Y)
                {
                    newA = (a.X - scale, a.Y);
                    newB = (b.X + scale, b.Y);
                }
                else if (a.Y > b.Y)
                {
                    newA = (a.X - scale, a.Y + scale);
                    newB = (b.X + scale, b.Y - scale);
                }
                else
                {
                    newA = (a.X - scale, a.Y - scale);
                    newB = (b.X + scale, b.Y + scale);
                }
            }
            return (newA, newB);
        }
    }
}
