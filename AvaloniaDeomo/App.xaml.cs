using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaDeomo
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
