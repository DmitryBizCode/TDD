using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal interface IRectangle : IArrow
    {
        float S();
        float P();
    }
}
