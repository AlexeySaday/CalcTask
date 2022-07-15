using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class CircleModel : IModelCircle
    {
        private double radius;
        public void GetData(double radius) => this.radius = radius;
        public double Result() => Math.PI * radius * radius;
    }
}
