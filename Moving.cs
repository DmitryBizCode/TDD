using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Moving : IMoving
    {
        private (float X, float Y) MoveNewXY(in (float X, float Y) a, in (float X, float Y) move) => (a.X + move.X, a.Y + move.Y);
        public ((float X, float Y), (float X, float Y), (float X, float Y), (float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, (float X, float Y) d, in (float X, float Y) move) 
        {
            var newA = MoveNewXY(a, move);
            var newB = MoveNewXY(b, move);
            var newC = MoveNewXY(c, move);
            var newD = MoveNewXY(d, move);
            return (newA, newB, newC, newD);
        }
        public ((float X, float Y),(float X, float Y),(float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, (float X, float Y) c, in (float X, float Y) move) 
        {
            var newA = MoveNewXY(a, move);
            var newB = MoveNewXY(b, move);
            var newC = MoveNewXY(c, move);

            return (newA, newB, newC);

        }        

        public ((float X, float Y),(float X, float Y)) Move((float X, float Y) a, (float X, float Y) b, in (float X, float Y) move)
        {
            var newA = MoveNewXY(a, move);
            var newB = MoveNewXY(b, move);
            return (newA, newB);
        }
    }
}
