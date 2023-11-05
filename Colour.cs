using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Colour
    {
        public void ReColour(IColorable colorable, string newColor)
        {
            colorable.Colour = newColor;
        }
    }
}
