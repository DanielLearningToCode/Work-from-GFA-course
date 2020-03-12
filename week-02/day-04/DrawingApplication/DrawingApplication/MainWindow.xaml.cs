using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);



            // Lines
            //foxDraw.DrawLine(0, 10, 100, 10);
            //foxDraw.SetStrokeColor(Colors.Green);
            //
            //var startPoint = new Point(0, 20);
            //var endPoint = new Point(100, 20);
            //foxDraw.DrawLine(startPoint, endPoint);

            // elipse
            //foxDraw.DrawEllipse(10, 10, 150, 50);

            //Rectangle
            //foxDraw.DrawRectangle(10, 10, 150, 50);

            //Polygon
            //var points = new List<Point>();
            //points.Add(new Point(10, 10));
            //points.Add(new Point(40, 210));
            //points.Add(new Point(170, 190));
            //points.Add(new Point(130, 40));
            //foxDraw.SetFillColor(Colors.Green);
            //foxDraw.DrawPolygon(points);

            // Middle lines
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.SetStrokeColor(Colors.Red);
            var yPosition = canvas.Height / 2;
            var xPosition = canvas.Width / 2;
            var length = 50;
            foxDraw.DrawLine(xPosition, yPosition, xPosition + length, yPosition);




















        }





        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}