using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace ToTheCenter
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
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            for (int i = 0; i < 3; i++)
            {

                LinesInTheCenter(i * 100, 100, foxDraw);

            }

#endif
        }

        private void LinesInTheCenter(double x, double y, FoxDraw foxDraw)
        {
            var xCenter = Width / 2;
            var yCenter = Height / 2;
            foxDraw.DrawLine(x, y, xCenter,yCenter);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
