using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    interface IModelTriangle
    {
        void GetValue(double valueA, double valueB, double valueC);
        double Result();
    }
}
