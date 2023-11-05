using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Scale : IScale
    {
        private void NewXY(ref (float X, float Y) a, int scale)
        {
            a.X += scale;
            a.Y += scale;
        }
        public void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, ref (float X, float Y) d, int scale)
        {
            NewXY(ref a, scale);
            NewXY(ref b, scale);
            NewXY(ref c, scale);
            NewXY(ref d, scale);
        }
        public void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, ref (float X, float Y) c, int scale) 
        {
            NewXY(ref a, scale);
            NewXY(ref b, scale);
            NewXY(ref c, scale);
        }
        public void Scaling(ref (float X, float Y) a, ref (float X, float Y) b, int scale)
        {
            NewXY(ref a, scale);
            NewXY(ref b, scale);
        }
    }
}
