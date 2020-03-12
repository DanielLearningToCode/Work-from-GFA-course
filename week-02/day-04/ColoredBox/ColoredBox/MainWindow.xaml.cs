using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace ColoredBox
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
            // Draw a box that has different colored lines on each edge.
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(100, 100, 200, 100);
            foxDraw.SetStrokeColor(Colors.Aquamarine);
            foxDraw.DrawLine(200, 100, 200, 200);
            foxDraw.SetStrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(200, 200, 100, 200);
            foxDraw.SetStrokeColor(Colors.CornflowerBlue);
            foxDraw.DrawLine(100, 200, 100, 100);



#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
