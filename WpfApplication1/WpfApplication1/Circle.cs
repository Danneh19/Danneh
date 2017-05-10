using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class Circle : Shape
    {
        private Ellipse ellipse;
        public Circle(int initx, int inity)
        {
            x = initx;
            y = inity;
            CreateEllipse();
        }

        private void CreateEllipse()
        {
            this.ellipse = new Ellipse();
            this.ellipse.Stroke = this.brush;
            this.ellipse.Height = this.size;
            this.ellipse.Width = this.size;
            this.ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.ellipse);
        }


    }
}