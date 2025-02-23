namespace MAUIsland;

public partial class StepperPage : IGalleryPage
{
    #region [CTor]
    public StepperPage(StepperPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
    #endregion

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e) 
    {
        double value = e.NewValue;
        _rotatingLabel.Rotation = value;
        _displayLabel.Text = string.Format("The Stepper value is {0}", value);

    }
}