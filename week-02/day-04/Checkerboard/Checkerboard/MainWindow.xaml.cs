using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace Checkerboard
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
            // Fill the canvas with a checkerboard pattern.
            int size = 10;
            double squaresPerLine = Width / size;
            double squaresPerColumn = Height / size;
            double offset = size;
            for (int i = 0; i < squaresPerColumn; i++)
            {
                for (int j = 0; j < squaresPerLine; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            foxDraw.SetFillColor(Colors.White);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.Black);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            foxDraw.SetFillColor(Colors.Black);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.White);
                        }
                    }
                    foxDraw.DrawRectangle(j * offset, i * offset, size, size);
                }
            }

#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
