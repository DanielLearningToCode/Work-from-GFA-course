using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace ConnectTheDots
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.AttachDevTools();
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            ////
            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            var box = new List<Point>();
            box.Add(new Point(10, 10));
            box.Add(new Point(290, 10));
            box.Add(new Point(290, 290));
            box.Add(new Point(10, 290));

            connectPoints(box, foxDraw);

            var shape = new List<Point>()
            {
                new Point(50, 100),
                new Point(70, 70),
                new Point(80, 90),
                new Point(90, 90),
                new Point(100, 70),
                new Point(120, 100),
                new Point(85, 130),
                new Point(50, 100)
            };

            connectPoints(shape, foxDraw);
        }

        private void connectPoints(List<Point> dots, FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Green);
            for (int i = 1; i < dots.Count; i++)
            {
                foxDraw.DrawLine(dots[i - 1], dots[i]);
            }
            foxDraw.DrawLine(dots[0], dots[dots.Count - 1]);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
