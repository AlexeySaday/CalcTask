using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class TriangleModel : IModelTriangle
    {
        private double a;
        private double b;
        private double c;

        public double Result() => AreaValue();
        public void GetValue(double valueA, double valueB, double valueC)
        {
            this.a = valueA;
            this.b = valueB;
            this.c = valueC;
        }
        
        private double AreaValue()
        {
            if (a >= b + c || b >= c + a || c >= a + b) throw new Exception();
            double maxValue = a;
            double first = b;
            double second = c;
            if (b > a)
            {
                maxValue = b;
                first = a;
                second = c;
                if (c > b) 
                {
                    maxValue = c;
                    first = b;
                    second = a;
                }
            }
            if (maxValue * maxValue == first * first + second * second) return first * second / 2;
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
