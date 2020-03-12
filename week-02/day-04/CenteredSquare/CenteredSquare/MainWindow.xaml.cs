using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace CenteredSquare
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
            // Draw a green 10x10 square to the canvas' center.
            var size = 10;
            var xCenter = Width / 2;
            var yCenter = Height / 2;
            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(xCenter - size / 2, yCenter - size / 2, size, size);
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
