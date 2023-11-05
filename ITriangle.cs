using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface ITriangle : IArrow
    {
        float P();
        float S();
    }
}
