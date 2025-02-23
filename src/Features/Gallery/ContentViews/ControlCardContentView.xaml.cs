namespace MAUIsland;
using System.Windows.Input;

public partial class ControlCardContentView : ContentView
{

    #region [CTor]
    public ControlCardContentView()
    {
        InitializeComponent();
    }
    #endregion

    #region [Delegates]
    public delegate void DetailEventHandler(IGalleryCardInfo control);

    public delegate void DetailInNewWindowEventHandler(IGalleryCardInfo control);
    #endregion

    #region [Event Handlers]
    public event DetailEventHandler DetailClicked;

    public event DetailInNewWindowEventHandler DetailInNewWindowClicked;
    #endregion

    #region [Bindable Properties]
    public static readonly BindableProperty ComponentDataProperty = BindableProperty.Create(
        nameof(ComponentData),
        typeof(IGalleryCardInfo),
        typeof(ControlCardContentView),
        default(IGalleryCardInfo)
    );

    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    #endregion

    #region [Properties]
    public IGalleryCardInfo ComponentData
    {
        get => (IGalleryCardInfo)GetValue(ComponentDataProperty);
        set => SetValue(ComponentDataProperty, value);
    }
    #endregion

    #region [Event Handlers]
    private void Detail_Clicked(object sender, EventArgs e)
    {
        DetailClicked?.Invoke(ComponentData);
    }

    private void DetailInNewWindow_Clicked(object sender, EventArgs e)
    {
        DetailInNewWindowClicked?.Invoke(ComponentData);
    }
    #endregion
}