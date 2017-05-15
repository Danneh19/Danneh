using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace ShapeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void drawSquareTest()
        {
            Rectangle testobject = new Rectangle();
            Canvas drawCanvas = new Canvas();
            drawSquare coloredSquare = new drawSquare(100, 100);
            coloredSquare.DisplayOn(drawCanvas);

            foreach (UIElement Child in drawCanvas.Children)
            {
                if (Child.GetType() == testobject.GetType())
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
                
            }
            
        }

        [TestMethod]
        public void drawCircleTest()
        {
            Ellipse testobject = new Ellipse();
            Canvas drawCanvas = new Canvas();
            drawCircle coloredCircle = new drawCircle(100, 100);
            coloredCircle.DisplayOn(drawCanvas);

            foreach (UIElement Child in drawCanvas.Children)
            {
                if (Child.GetType() == testobject.GetType())
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }

            }

        }

        [TestMethod]
        public void drawLineTest()
        {
            Line testobject = new Line();
            Canvas drawCanvas = new Canvas();
            drawLine coloredLine = new drawLine(100, 100);
            coloredLine.DisplayOn(drawCanvas);

            foreach (UIElement Child in drawCanvas.Children)
            {
                if (Child.GetType() == testobject.GetType())
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }

            }

        }

        [TestMethod]
        public void canvasCheckIfNotEmpty()
        {
            Canvas drawCanvas = new Canvas();

            drawSquare coloredSquare = new drawSquare(100, 100);
            coloredSquare.DisplayOn(drawCanvas);

            drawCircle coloredCircle = new drawCircle(100, 100);
            coloredCircle.DisplayOn(drawCanvas);

            drawLine coloredLine = new drawLine(100, 100);
            coloredLine.DisplayOn(drawCanvas);

            Assert.IsTrue(drawCanvas.Children.Count == 3);
        }

        [TestMethod]
        public void ColorTest()
        {
            
        }
    }
}
