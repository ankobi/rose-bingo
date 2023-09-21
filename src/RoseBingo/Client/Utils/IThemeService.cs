using MudBlazor;

namespace RoseBingo.Client.Utils
{
    public interface IThemeService
    {
        MudTheme Theme { get; }

        bool IsDarkMode { get; set; }
    }
}
