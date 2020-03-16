using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace Naboje2
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
            int xStred = Convert.ToInt32(1366/ 2);
            int yStred = Convert.ToInt32(Height / 2);

            // foxDraw.SetStrokeColor(Colors.Blue);
            /* foxDraw.SetStrokeThicknes(4);
             drawSun(xStred, yStred, foxDraw);
            // foxDraw.SetStrokeColor(Colors.Red);
             drawSun(xStred + 16, yStred, foxDraw);
            // foxDraw.SetStrokeColor(Colors.Green);
             drawSun(xStred + 8, yStred + 14, foxDraw);
 */         foxDraw.SetStrokeThicknes(4);
            drawSun(xStred-8, yStred-8, foxDraw);
            // foxDraw.SetStrokeColor(Colors.Red);
            drawSun(xStred + 8, yStred - 8, foxDraw);
            // foxDraw.SetStrokeColor(Colors.Green);
            drawSun(xStred +8, yStred + 8, foxDraw);
            drawSun(xStred - 8, yStred + 8, foxDraw);



#endif
        }

        private void drawSun(int x, int y, FoxDraw foxDraw)
        {
            double numOfLines = 160;
            double angleStep = 360 / numOfLines;
            int radius = 650;
            
            for (int n = 0; n < numOfLines; n++)
            {
                double angle = n * angleStep;
                double angleRad = angle * (Math.PI / 180.0);
                int x2 = Convert.ToInt32(x + radius * Math.Cos(angleRad));
                int y2 = Convert.ToInt32(y - radius * Math.Sin(angleRad));
                foxDraw.DrawLine(x, y, x2, y2);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
