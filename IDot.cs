using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IDot
    {
        (float X, float Y) A { get; set; }
        (float X, float Y) B { get; set; }
        (float X, float Y) C { get; set; }
        (float X, float Y) D { get; set; }
    }
}
