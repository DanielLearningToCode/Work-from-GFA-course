using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace EverythingGoesToTheCenter
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
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.
            int x = 0;
            int y = 0;
            double shift = 20;
          //  Height = Width;
            double canvasSide = Width;
            double numOfLinesPerSide = canvasSide / shift;

            for (int i = 0; i < numOfLinesPerSide; i++)
            {
                Line(x + shift * i, y, foxDraw);
            }

            for (int i = 0; i < numOfLinesPerSide; i++) 
            {
                Line(Width, y + shift * i, foxDraw);
            }

            for (int i = 0; i < numOfLinesPerSide; i++)
            {
                Line(x + shift * i, Height, foxDraw);
            }

            for (int i = 0; i < numOfLinesPerSide; i++)
            {
                Line(x, y + shift * i, foxDraw);
            }

#endif
        }

        private void Line(double x, double y, FoxDraw foxDraw)
        {
            double xCenter = Width / 2;
            double yCenter = Height / 2;
            foxDraw.DrawLine(x, y, xCenter, yCenter);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
