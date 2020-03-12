using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace LiensInTheMiddle
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
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(350, 225, 450, 225);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(400, 175, 400, 275);
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
