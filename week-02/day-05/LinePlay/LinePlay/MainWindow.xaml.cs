using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace LinePlay
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

            var shift = Width / 15;
            foxDraw.SetStrokeColor(Colors.Orchid);
            for (int i = 0; i < 15; i++)
            {
            foxDraw.DrawLine(shift * i, 0, Width, shift * i);
            }
            foxDraw.SetStrokeColor(Colors.Lime);
            for (int i = 0; i < 15; i++)
            {
                foxDraw.DrawLine(0, shift *i, shift * i, Height);
            }
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
