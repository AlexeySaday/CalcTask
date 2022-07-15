using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class TrianglePresenter
    {
        IModelTriangle model;
        IViewTriangle view;

        public TrianglePresenter(IViewTriangle view)
        {
            this.view = view;
            model = new TriangleModel();
        }
        public void Result()
        {
            model.GetValue(view.ValueA, view.ValueB, view.ValueC);
            view.Result = model.Result();
        }
    }
}
