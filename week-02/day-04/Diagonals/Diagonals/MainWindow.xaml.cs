using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace Diagonals
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

            var height = Height;
            var width = Width;
            ////
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            var upperLeft = new Point(0, 0);
            var upperRight = new Point(width, 0);
            var bottomLeft = new Point(0, height);
            var bottomRight = new Point(width, height);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(upperLeft, bottomRight);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(bottomLeft, upperRight);

#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
