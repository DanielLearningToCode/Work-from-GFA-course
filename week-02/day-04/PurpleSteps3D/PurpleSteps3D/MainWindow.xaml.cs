using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace PurpleSteps3D
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
            int size = 10;
            int offset = 10;
            int multiplier = 0;
            int increment = 0;
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 1; i < 10; i++)
            {
                foxDraw.DrawRectangle(offset,offset ,size*i, size*i);
                multiplier++;
                increment = multiplier * 10;
                offset += increment; 
            }
#endif
            /*   foxDraw.DrawRectangle(size, size, size, size);
               foxDraw.DrawRectangle(size*2, size*2, size*2, size*2);
               foxDraw.DrawRectangle(size*4, size*4, size*3, size*3);
               foxDraw.DrawRectangle(size*7, size*7, size*4, size*4);*/
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
