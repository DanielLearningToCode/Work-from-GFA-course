using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace StarryNight
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
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);

            for (int i = 0; i < 100; i++)
            {
            square(foxDraw);
            }
#endif
        }

        private void square(FoxDraw foxDraw)
        {
            Random rnd = new Random();
            var xPosition = rnd.Next(0, Convert.ToInt32(Width));
            var yPosition = rnd.Next(0, Convert.ToInt32(Height));
            var size = rnd.Next(1,15);
            var listOfColors = new List<Color>()
            {
                Colors.Yellow,
                Colors.WhiteSmoke,
                Colors.GreenYellow,
                Colors.GreenYellow,
                Colors.DimGray,
                Colors.Gold,
                Colors.LightYellow,
                Colors.LightGoldenrodYellow
            };
            var randomColor = listOfColors[rnd.Next(0, listOfColors.Count)];
            foxDraw.SetFillColor(randomColor);
            foxDraw.DrawRectangle(xPosition, yPosition, size, size);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
