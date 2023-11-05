using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Moving : IMoving
    {
        private void MoveNewXY(ref (float X, float Y) a, in (float X, float Y) move)
        {
            a.X += move.X;
            a.Y += move.Y;
        }
        public void Move(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, in (float X, float Y) move) 
        {
            MoveNewXY(ref a,move); 
            MoveNewXY(ref b,move);
            MoveNewXY(ref c,move);
            MoveNewXY(ref d,move);
        }
        public void Move(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, in (float X, float Y) move) 
        {
            MoveNewXY(ref a, move);
            MoveNewXY(ref b, move);
            MoveNewXY(ref c, move);
        }
        public void Move(ref (float X, float Y) a, ref (float X, float Y) b, in (float X, float Y) move)
        {
            MoveNewXY(ref a, move);
            MoveNewXY(ref b, move);
        }
    }
}
