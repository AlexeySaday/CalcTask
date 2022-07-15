using System; 
using System.Windows; 

namespace Area
{ 
    public partial class MainWindow : Window,IViewCircle,IViewTriangle
    {
        CirclePresenter presenter;
        TrianglePresenter trianglePresenter;
        public MainWindow()
        {
            InitializeComponent();
            CircleClick.Click += (s, e) => { CircleView.Visibility = Visibility.Visible; Choice.Visibility = Visibility.Hidden; };
            TriangleClick.Click += (s, e) => { TriangleView.Visibility = Visibility.Visible; Choice.Visibility = Visibility.Hidden; };

            presenter = new CirclePresenter(this);
            trianglePresenter = new TrianglePresenter(this);

            CalcClick.Click += (s, e) => presenter.Result();
            CalcTrClick.Click += (s, e) => trianglePresenter.Result();
        } 
        public double ValueA { get => Convert.ToDouble(txtValueA.Text); }
        public double ValueB { get => Convert.ToDouble(txtValueB.Text); }
        public double ValueC { get => Convert.ToDouble(txtValueC.Text); }
        public double Result { set => txtResult.Text = value.ToString(); }

        public double Radius { get => Convert.ToDouble(txtRadius.Text); }
        public double Area { set => txtArea.Text = value.ToString(); }
    }
}
