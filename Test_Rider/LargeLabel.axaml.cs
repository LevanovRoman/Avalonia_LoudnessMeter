using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Test_Rider;

public class LargeLabel : TemplatedControl
{
    public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<LargeLabel, string>(
        nameof(LargeText), "LARGE TEXT");

    public string LargeText
    {
        get => GetValue(LargeTextProperty);
        set => SetValue(LargeTextProperty, value);
    }

    public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<LargeLabel, string>(
        nameof(SmallText), "SMALL TEXT");

    public string SmallText
    {
        get => GetValue(SmallTextProperty);
        set => SetValue(SmallTextProperty, value);
    }
}

