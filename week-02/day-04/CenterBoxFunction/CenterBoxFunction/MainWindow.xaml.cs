using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace CenterBoxFunction
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
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            
            List<Color> myColor = new List<Color>();
            myColor.Add(Colors.Red);
            myColor.Add(Colors.Green);
            myColor.Add(Colors.Blue);

            double scale = 2;
            for (int i = 1; i < 4; i++)
            {
                foxDraw.SetFillColor(myColor[i - 1]);
                square(50 * scale, foxDraw);
                scale -= 0.4;
            }
#endif
        }

        private void square(double size, FoxDraw foxDraw)
        {
            double xCenter = Width / 2 - size / 2;
            double yCenter = Height / 2 - size / 2;
            foxDraw.DrawRectangle(xCenter, yCenter, size, size);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
