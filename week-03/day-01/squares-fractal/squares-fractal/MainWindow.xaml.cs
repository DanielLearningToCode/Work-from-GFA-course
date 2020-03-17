using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace squares_fractal
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

            double level = 1;
            double leftEnd = 0;
            double rightEnd = Width;
            double top = 0;
            double bottom = Height;
            DrawSquare(1, leftEnd, rightEnd, top, bottom, foxDraw);
#endif
        }

        private void DrawSquare(double level, double leftEnd, double rightEnd, double top, double bottom, FoxDraw foxDraw)
        {
            double scale = 1 / 3;
            if (level == 1)
            {
            double x1 = leftEnd;
            double x2 = rightEnd;
            double y1 = (bottom-top) / 3;
            double y2 = y1;
            foxDraw.DrawLine(x1, y1, x2, y2);

            double x3 = leftEnd;
            double x4 = rightEnd;
            double y3 = y1 * 2;
            double y4 = y3;
            foxDraw.DrawLine(x3, y3, x4, y4);

            double x5 = (rightEnd - leftEnd) /3;
            double x6 = x5;
            double y5 = top;
            double y6 = bottom;
            foxDraw.DrawLine(x5, y5, x6, y6);

            double x7 = x5 * 2;
            double x8 = x7;
            double y7 = top;
            double y8 = bottom;
            foxDraw.DrawLine(x7, y7, x8, y8);

            }
            else
            {
                DrawSquare(level - 1, foxDraw);
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
