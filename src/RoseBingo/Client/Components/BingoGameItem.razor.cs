using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace RoseBingo.Client.Components
{
    public partial class BingoGameItem
    {
        private const string height = "120px";
        private const string progressColor = "#FFEB3B";

        [Parameter]
        public string Value { get; set; } = string.Empty;

        [Parameter]
        public int Amount { get; set; } = 1;

        [Parameter]
        public int Counter { get; set; } = 1;

        private string GetStyle()
        {
            string style = $"height:{height};text-align:center;";

            if (Amount >  1 && Counter > 0)
            {
                int currentProgress = 100 / Amount * Counter;
                style += $";background: linear-gradient(to right, {progressColor} 0%,{progressColor} {currentProgress}%,white {currentProgress + 1}%,white 100%)";
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

        private void CountUp()
        {
            if (Counter < Amount)
            {
                Counter++;
            }
        }

        private void CountDown()
        {
            if (Counter > 0) 
            {
                Counter--;
            }
        }
    }
}
