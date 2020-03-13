using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;

namespace LinePlayQuarters
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
            var shiftRight = Width / 8;
            var shiftDown = Height / 8;

            for (int j = 0; j < 16; j++)   // shifting down
            {
                for (int i = 0; i < 16; i++)  // shifting on a line line
                {

                    shape(Convert.ToInt32(shiftRight) * i, Convert.ToInt32(shiftDown) * j, foxDraw);

                }

            }
           
#endif
        }

        private void shape(int shiftOfxCoordinates, int shiftOfyCoordinates, FoxDraw foxDraw)
        {
            var fraction = Width / 8;
            var shift = fraction / 15;
            var top = 0 + shiftOfyCoordinates;
            var bottom = fraction + shiftOfyCoordinates;
            var left = 0 + shiftOfxCoordinates;
            var right = fraction + shiftOfxCoordinates;

            foxDraw.SetStrokeColor(Colors.Orchid);
            for (int i = 0; i < 15; i++)
            {
                foxDraw.DrawLine(left + shift * i , top, right, top + shift * i);
            }
            foxDraw.SetStrokeColor(Colors.Lime);
            for (int i = 0; i < 15; i++)
            {
                foxDraw.DrawLine(left, top + shift * i, left + shift * i, bottom);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
