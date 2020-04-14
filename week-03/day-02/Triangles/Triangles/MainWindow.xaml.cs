using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace Triangles
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            ////
            ///
            foxDraw.SetFillColor(RandomColor());
            DrawTriangle(0, 0, Width, 10, foxDraw);
#endif
        }

        public static Color RandomColor()
        {
            Random rnd = new Random();
            List<Color> colors = new List<Color>
            {
                Colors.AliceBlue,
                Colors.Aquamarine,
                Colors.Azure,
                Colors.BlueViolet,
                Colors.Chocolate,
                Colors.Cyan,
                Colors.DarkGoldenrod,
                Colors.DarkMagenta,
                Colors.DarkRed,
                Colors.Yellow,
                Colors.Gold,
                Colors.Purple,
                Colors.Red,
                Colors.Pink,
                Colors.SeaShell,
                Colors.Silver,
                Colors.Green
            };
            Color randColor = colors[rnd.Next(0, colors.Count)];
            return randColor;
        }
        private void DrawTriangle(double x, double y, double size, int level, FoxDraw foxDraw)
        {
            if (level == 0)
            {
                return;
            }
            // upside down triangle
            double halfOfSide = size / 2;
            //double twoThirds = 2 * halfOfSide;
            var leftTop = new Point(x, y);
            var rightTop = new Point(x + size, y);
            var heightReversedTriangle = Math.Sqrt((size * size) - (Math.Pow(0.5 * size, 2)));
            var bottom = new Point(x + halfOfSide, y + heightReversedTriangle);
            var bottomUpTriangle = new List<Point>() { leftTop, rightTop, bottom };
            foxDraw.DrawPolygon(bottomUpTriangle);
            // right way up triangle
            var heightUpTriangle = Math.Sqrt((halfOfSide * halfOfSide) - (Math.Pow(0.5 * halfOfSide, 2)));
            var bottomLeft = new Point(x + 0.5 * halfOfSide, y + heightUpTriangle);
            var bottomRight = new Point(x + 0.5 * halfOfSide + halfOfSide, y + heightUpTriangle);
            var top = new Point(x + halfOfSide, y);
            var topUpTriangle = new List<Point>() { bottomLeft, bottomRight, top };
            foxDraw.DrawPolygon(topUpTriangle);

            level--;
            foxDraw.SetFillColor(RandomColor());
           // DrawTriangle(x, y, size * 0.5, level, foxDraw);
            foxDraw.SetFillColor(RandomColor());
//DrawTriangle(x + halfOfSide, y, size * 0.5, level, foxDraw);
            foxDraw.SetFillColor(RandomColor());
            DrawTriangle(x + halfOfSide * 0.5, y + heightUpTriangle, size * 0.5 , level, foxDraw);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
