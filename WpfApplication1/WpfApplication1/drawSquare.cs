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
    public class drawSquare : Shape, iDisplayable
    {
        public static List<string> shapeRect = new List<string>();
        private Rectangle rect;
        public drawSquare(int initX, int initY)
        {
            this.x = initX;
            this.y = initY;
            CreateRectangle(false);
        }

        public drawSquare(int initx , int initY , Color shapeColor)
        {
            this.x = initx;
            this.y = initY;
            this.ShapeColor = shapeColor;
            CreateRectangle(true);
        }

        private void CreateRectangle(bool color)
        {
            ToolTip tt = new ToolTip();
            this.rect = new Rectangle();
            if (color)
            {
                this.rect.Fill = new SolidColorBrush(ShapeColor);
                tt.Content = rect.Fill;
            }
            this.rect.Stroke = this.brush;
            this.rect.Height = this.size;
            this.rect.Width = this.size;
            this.rect.Margin = new System.Windows.Thickness(this.x, this.y, 0, 0);
            rect.ToolTip = tt;
            save();
        }
        public void save()
        {
            string FileName = "../../Save/mysecretfile.txt";

            string mystrXAML = XamlWriter.Save(this.rect);
            StreamWriter streamwriter = new StreamWriter(FileName, true);

            shapeRect.Add(mystrXAML);

            streamwriter.Close();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.rect);
        }
    }
}