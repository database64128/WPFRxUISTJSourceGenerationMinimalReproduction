using System.Text.Json;

namespace WPFRxUISTJSourceGenerationMinimalReproduction;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        _ = JsonSerializer.Serialize(new Settings(), SettingsJsonSerializerContext.Default.Settings);
    }
}
