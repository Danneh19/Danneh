using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            ShapesBox.Items.Add("Square");
            ShapesBox.Items.Add("Circle");
            ShapesBox.Items.Add("Line");

        }
        /// <summary>
        /// Handles the MouseUp event of the drawCanvas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void drawCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            drawCircle circle1 = new drawCircle(40,40);
            drawSquare square1 = new drawSquare(180, 180);
            drawLine line1 = new drawLine(200, 100 , 300, 100);
            List<Shape> groupe = new List<Shape>();
            groupe.Add(circle1);
            groupe.Add(square1);
            groupe.Add(line1);

            foreach(Shape shape in groupe)
            {
                shape.DisplayOn(this.drawCanvas);
            }
        } 
    }
}
