using Microsoft.AspNetCore.Components;
using MudBlazor;
using RoseBingo.Client.Utils;

namespace RoseBingo.Client.Components
{
    public partial class BingoGameItem
    {
        private const string height = "200px";
        private const string progressColorLight = "#FFEB3B";
        private const string progressColorDark = "#FF4400";
        private const string backgroundColorDark = "#373740";

        [Inject]
        private IThemeService? ThemeService { get; set; }

        [Parameter]
        public string Value { get; set; } = string.Empty;

        [Parameter]
        public int Amount { get; set; } = 1;

        [Parameter]
        public int Counter { get; set; } = 1;

        [Parameter]
        public EventCallback<int> CounterChanged { get; set; }

        private string GetStyle()
        {
            var backgroundColor = "white";
            var progressColor = progressColorLight;
            if (ThemeService?.IsDarkMode ?? false)
            {
                backgroundColor = backgroundColorDark;
                progressColor = progressColorDark;
            }

            string style = $"height:{height};text-align:center;";

            if (Amount >  1 && Counter > 0)
            {
                int currentProgress = 100 / Amount * Counter;
                style += $";background: linear-gradient(to right, {progressColor} 0%,{progressColor} {currentProgress}%,{backgroundColor} {currentProgress + 1}%,{backgroundColor} 100%)";
            }
            else
            {
                if (Amount == 1 && Counter == 1)
                {
                    style += $";background-color: {progressColor}";
                }
            }
            return style;
        }

        private string GetTextStyle()
        {
            if (Value.Length <= 10)
            {
                return "font-size: xxx-large";
            }
            else
            {
                if (Value.Length <= 30)
                {
                    return "font-size: xx-large";
                }
                else
                {
                    if (Value.Length <= 60)
                    {
                        return "font-size: x-large";
                    }
                    else
                    {
                        return "font-size: large";
                    }
                }
            }
        }

        private async void CountUp()
        {
            if (Counter < Amount)
            {
                Counter++;
                await CounterChanged.InvokeAsync(Counter);
            }
        }

        private async void CountDown()
        {
            if (Counter > 0) 
            {
                Counter--;
                await CounterChanged.InvokeAsync(Counter);
            }
        }
    }
}
