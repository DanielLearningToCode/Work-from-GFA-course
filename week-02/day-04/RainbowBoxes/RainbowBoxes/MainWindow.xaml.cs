using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace RainbowBoxes
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
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).
            List<Color> myColor = new List<Color>();
            myColor.Add(Colors.Red);
            myColor.Add(Colors.Orange);
            myColor.Add(Colors.Yellow);
            myColor.Add(Colors.Green);
            myColor.Add(Colors.Blue);
            myColor.Add(Colors.Indigo);
            myColor.Add(Colors.Violet);

            double scale = 1;
            for (int i = 0; i < 7; i++)
            {
                square(200 * scale,myColor[i], foxDraw);
                scale *= 0.9;
            }
#endif
        }

        private void square(double size, Color rainbow, FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(rainbow);
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
