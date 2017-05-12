using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication1
{
    public abstract class Shape : iDisplayable
    {
        protected int x;
        protected int y;
        protected Color ShapeColor;
        protected int x1;
        protected int y2;
        protected int x2;
        protected int y1;
        protected int size = 75;
        protected SolidColorBrush brush = new SolidColorBrush(Colors.Black);

        public abstract void DisplayOn(Canvas drawCanvas);

    }
}
