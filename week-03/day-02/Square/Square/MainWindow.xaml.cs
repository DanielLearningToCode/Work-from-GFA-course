using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace Square
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
            foxDraw.SetFillColor(Colors.Yellow);
            DrawSquares(0, 0, Width, 5, foxDraw);
#endif
        }
        public static void DrawSquares(double x, double y, double size, int repeat, FoxDraw foxDraw)
        {
            if (repeat == 0)
            {
                return;
            }
            double third = size / 3;
            double twoThirds = 2 * size / 3;

            foxDraw.DrawRectangle(x, y + third, third, third); // left middle
            foxDraw.DrawRectangle(x + third, y, third, third);  // top middle
            foxDraw.DrawRectangle(x + twoThirds, y + third, third, third);  // right middle
            foxDraw.DrawRectangle(x + third, y + twoThirds, third, third);  // bottom middle

            repeat--;
            DrawSquares(x, y+third, third, repeat, foxDraw);   // draw 4 squares in the left middle square
            DrawSquares(x + third, y, third, repeat, foxDraw);  // draw 4 squares in the 
            DrawSquares(x + twoThirds, y + third, third, repeat, foxDraw);
            DrawSquares(x + third, y + twoThirds, third, repeat, foxDraw);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
