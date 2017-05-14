using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    
    public class drawCircle : Shape, iDisplayable
    {
        public static List<string> shapeEllipse = new List<string>();
        private Ellipse ellipse;
        public drawCircle(int initx, int inity)
        {
            x = initx;
            y = inity;
            CreateEllipse(false);
        }

        public drawCircle(int initx , int inity , Color shapeColor)
        {
            x = initx;
            y = inity;
            ShapeColor = shapeColor;
            CreateEllipse(true);
        }

        private void CreateEllipse(bool color)
        {
            ToolTip tt = new ToolTip();
            this.ellipse = new Ellipse();
            if (color)
            {
                this.ellipse.Fill = new SolidColorBrush(ShapeColor);
                tt.Content = ellipse.Fill;
            }                 
            this.ellipse.Stroke = this.brush;
            this.ellipse.Height = this.size;
            this.ellipse.Width = this.size;
            this.ellipse.Margin = new Thickness(x, y, 0, 0);                                
            ellipse.ToolTip = tt;
            save();
        }
        public void save()
        {
            
            
            string FileName = "../../Save/mysecretfile.txt";

            string mystrXAML = XamlWriter.Save(this.ellipse);
            StreamWriter streamwriter = new StreamWriter(FileName, true);

            shapeEllipse.Add(mystrXAML);

            streamwriter.Close();
            
        }
        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.ellipse);
        }


    }
}