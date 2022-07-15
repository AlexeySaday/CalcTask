using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class CirclePresenter
    {
        IViewCircle view;
        IModelCircle model;

        public CirclePresenter(IViewCircle view)
        {
            this.view = view;
            model = new CircleModel();
        }
        public void Result()
        {
            model.GetData(view.Radius);
            view.Area = model.Result();
        }
    }
}
