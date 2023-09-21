using MudBlazor;

namespace RoseBingo.Client.Utils
{
    public class ThemeService : IThemeService
    {
        public MudTheme Theme { get; } = new MudTheme()
        {
            Palette = new PaletteLight()
            {
                Background = Colors.Grey.Lighten5,
                Primary = "#FF4400",
                AppbarBackground = "#FF4400"
            },
            PaletteDark = new PaletteDark()
            {
                Background = Colors.Amber.Accent4
            }
        };
        public bool IsDarkMode { get ; set; }
    }
}
