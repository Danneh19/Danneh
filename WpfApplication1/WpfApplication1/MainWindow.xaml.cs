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
       
        public string CheckCbItem()
        {
            string SelectedItem = "";
            switch(ShapesBox.SelectedIndex){
                case 1:
                    SelectedItem = "Square";
                    break;
                case 2:
                    SelectedItem = "Circle";
                    break;
                case 3:
                    SelectedItem = "Line";
                    break;                    
            }
            return SelectedItem;
        }
        
        

    }
}
