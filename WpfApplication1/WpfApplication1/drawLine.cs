using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Markup;
using System.IO;

namespace WpfApplication1
{
    public class drawLine : Shape, iDisplayable
    {
        private Line line;
        public static List<string> shapeLine = new List<string>();
        public drawLine(int initX1, int initY1)
        {
            x1 = initX1;
            y1 = initY1;
            x2 = initX1 + 50;
            y2 = initY1 + 50;
            CreateLine(false);
        }

        public drawLine(int initX1, int initY1, Color shapeColor)
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
            ToolTip tt = new ToolTip();
            line = new Line();
            if (color)
            {
                line.Stroke = new SolidColorBrush(ShapeColor);
                tt.Content = line.Stroke;
            }
            else
            {
                line.Stroke = brush;
            }
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;
            line.StrokeThickness = 2;
            line.ToolTip = tt;
            save();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.line);
        }
        public void save()
        {
            
            string mystrXAML = XamlWriter.Save(this.line);

            shapeLine.Add(mystrXAML);
            
        }
    }
}