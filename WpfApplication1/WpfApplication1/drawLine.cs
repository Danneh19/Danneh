using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WpfApplication1
{
    public class drawLine : Shape
    {
        private Line line;

        public drawLine(int initX1, int initY1)
        {
            x1 = initX1;
            y1 = initY1;
            x2 = initX1 + 50;
            y2 = initY1 + 50;
            CreateLine(false);                
        }
        
        public drawLine(int initX1 , int initY1 , Color shapeColor)
        {
            x1 = initX1;
            y1 = initY1;
            x2 = initX1 + 50;
            y2 = initY1 + 50;
            ShapeColor = shapeColor;
            CreateLine(true);
        }

        private void CreateLine(bool color)
        {
            line = new Line();
            if (color)
            {
                line.Stroke = new SolidColorBrush(ShapeColor);
            }
            else {
                line.Stroke = brush;
            }
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