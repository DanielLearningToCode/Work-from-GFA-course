using Avalonia;
using Avalonia.Markup.Xaml;
using DrawingApplication;

namespace DrawingApplication
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
