using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace FourRectangles
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
            // draw four different size and color rectangles.
            // avoid code duplication.
           /* var size = 10;
            var offset = 10;*/
            var rnd = new Random();
            var randColor = new List<Color>();
            randColor.Add(Colors.AliceBlue);
            randColor.Add(Colors.Purple);
            randColor.Add(Colors.Orange);
            randColor.Add(Colors.Green);


            for (int i = 1; i < 5; i++)
            {
                foxDraw.SetFillColor(randColor[rnd.Next(0, 4)]);
                foxDraw.DrawRectangle(rnd.Next(0, 400), rnd.Next(0, 400), rnd.Next(10, 100), rnd.Next(10, 100));
            }

#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
