using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WpfApplication1
{
    public class drawSquare : Shape
    {
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
            this.rect = new Rectangle();
            if (color)
            {
                this.rect.Fill = new SolidColorBrush(ShapeColor);
            }
            this.rect.Stroke = this.brush;
            this.rect.Height = this.size;
            this.rect.Width = this.size;
            this.rect.Margin = new System.Windows.Thickness(this.x, this.y, 0, 0);
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.rect);
        }
    }
}