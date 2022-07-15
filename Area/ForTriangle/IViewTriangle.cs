using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    interface IViewTriangle
    {
        double ValueA { get; }
        double ValueB { get; }
        double ValueC { get; }
        double Result { set; }
    }
}
