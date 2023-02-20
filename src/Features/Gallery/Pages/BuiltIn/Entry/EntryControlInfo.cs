﻿namespace MAUIsland.Gallery.BuiltIn;

class EntryControlInfo : IControlInfo
{
    public string ControlName => nameof(Entry);
    public string ControlRoute => typeof(EntryPage).FullName;
    public ImageSource ControlIcon => new FontImageSource()
    {
        FontFamily = FontNames.FluentSystemIconsRegular,
        Glyph = FluentUIIcon.Ic_fluent_text_field_24_regular
    };
    public string ControlDetail => "Entry allows you to enter and edit a single line of text. In addition, the Entry can be used as a password field.\r\n\r\n";
    public string GitHubUrl => $"https://github.com/Strypper/mauisland/tree/main/src/Features/Gallery/Pages/BuiltIn/{ControlName}";
    public string DocumentUrl => $"https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/{ControlName}/?view=net-maui-7.0";
    public string GroupName => ControlGroupInfo.BuiltInControls;
}
