﻿using System;
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
                case 0:
                    SelectedItem = "Square";
                    break;
                case 1:
                    SelectedItem = "Circle";
                    break;
                case 2:
                    SelectedItem = "Line";
                    break;                    
            }
            return SelectedItem;
        }

        private void drawCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            if (CheckCbItem() == "")
            {
                // Alert maken die de gebruiker laat weten dat hij beter wat gaat invullen of anders...   
                             
            }
            else if (CheckCbItem() == "Square")
            {
                // methode maken die een gekleurd vierkantje op de geklikte plek laat zien
                drawSquare coloredSquare = new drawSquare((int)Mouse.GetPosition(drawCanvas).X, (int)Mouse.GetPosition(drawCanvas).Y, RandomColor.getColor());
                coloredSquare.DisplayOn(drawCanvas);
            }
            else if (CheckCbItem() == "Circle")
            {
                // methode maken die een gekleurd circeltje op de geklikte plek laat zien
                drawCircle coloredCircle = new drawCircle((int)Mouse.GetPosition(drawCanvas).X, (int)Mouse.GetPosition(drawCanvas).Y , RandomColor.getColor());
                coloredCircle.DisplayOn(drawCanvas);
            }
            else if (CheckCbItem() == "Line")
            {
                // methode maken die een gekleurd Lijntje op de geklikte plek laat zien
                drawLine coloredLine = new drawLine((int)Mouse.GetPosition(drawCanvas).X, (int)Mouse.GetPosition(drawCanvas).Y, RandomColor.getColor());
                coloredLine.DisplayOn(drawCanvas);
            }
        }

        private void drawCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (CheckCbItem() == "")
            {
                // Alert maken die de gebruiker laat weten dat hij beter wat gaat invullen of anders...
            }
            else if (CheckCbItem() == "Square")
            {
                // methode maken die een vierkantje op de geklikte plek laat zien
                drawSquare square = new drawSquare((int)Mouse.GetPosition(drawCanvas).X, (int)Mouse.GetPosition(drawCanvas).Y);
                square.DisplayOn(drawCanvas);
            }
            else if (CheckCbItem() == "Circle")
            {
                drawCircle circle1 = new drawCircle((int)Mouse.GetPosition(drawCanvas).X , (int)Mouse.GetPosition(drawCanvas).Y);
                circle1.DisplayOn(drawCanvas);
            }
            else if (CheckCbItem() == "Line")
            {
                // methode maken die een Lijntje op de geklikte plek laat zien
                drawLine line = new drawLine((int)Mouse.GetPosition(drawCanvas).X, (int)Mouse.GetPosition(drawCanvas).Y);
                line.DisplayOn(drawCanvas);
            }
        }

        private void drawCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Polyline poly = new Polyline();
            poly.Stroke = new SolidColorBrush(Colors.Blue);
            poly.StrokeThickness = 4;

            Point Point1 = new Point((int)Mouse.GetPosition(drawCanvas).X , (int)Mouse.GetPosition(drawCanvas).X + 90);
            Point Point2 = new Point((int)Mouse.GetPosition(drawCanvas).X + 90, (int)Mouse.GetPosition(drawCanvas).X + 190);
            Point Point3 = new Point((int)Mouse.GetPosition(drawCanvas).X + 190, (int)Mouse.GetPosition(drawCanvas).X + 20);
            Point Point4 = new Point((int)Mouse.GetPosition(drawCanvas).X + 240, (int)Mouse.GetPosition(drawCanvas).X + 190);
            Point Point5 = new Point((int)Mouse.GetPosition(drawCanvas).X + 190, (int)Mouse.GetPosition(drawCanvas).X + 140);

            PointCollection polyPoints = new PointCollection();
            polyPoints.Add(Point1);
            polyPoints.Add(Point2);
            polyPoints.Add(Point3);
            polyPoints.Add(Point4);
            polyPoints.Add(Point5);

            poly.Points = polyPoints;

            drawCanvas.Children.Add(poly);
        }
    }
}
