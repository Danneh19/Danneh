using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class Square : Shape
    {
        private Rectangle rect;
        public Square(int initX, int initY)
        {
            this.x = initX;
            this.y = initY;
            CreateRectangle();
        }

        private void CreateRectangle()
        {
            this.rect = new Rectangle();
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