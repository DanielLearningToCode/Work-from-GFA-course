using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace PurpleSteps
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
            int xLeftUpper = 0;
            int yLeftUpper = 0;
            int size = 10;

            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 1; i < 20; i++)
            {
                foxDraw.DrawRectangle(xLeftUpper + i * size, yLeftUpper + i * size, size, size);


            }
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
