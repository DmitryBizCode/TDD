using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IArrow
    {
        float Length((float X, float Y) a, (float X, float Y) b);
    }
    public interface IColorable
    {
        string Colour { get; set; }
    }

}
