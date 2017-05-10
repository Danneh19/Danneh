using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class drawLine : Shape
    {
        private Line line;

        public drawLine(int initX1, int initY1, int initX2, int initY2)
        {
            x1 = initX1;
            y1 = initY1;
            x2 = initX2;
            y2 = initY2;
            CreateLine();
                
        }

        private void CreateLine()
        {
            line = new Line();
            line.Stroke = brush;
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;
            line.StrokeThickness = 2;
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.line);
        }
    }
}