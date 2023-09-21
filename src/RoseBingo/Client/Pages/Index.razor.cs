using Microsoft.AspNetCore.Components;
using RoseBingo.Client.Utils;
using System.Text;

namespace RoseBingo.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private NavigationManager? NavManager { get; set; }

        [Parameter]
        public string Data { get; set; } = string.Empty;

        private string valueB1 = string.Empty;
        private string valueB2 = string.Empty;
        private string valueB3 = string.Empty;
        private string valueB4 = string.Empty;
        private string valueB5 = string.Empty;

        private string valueI1 = string.Empty;
        private string valueI2 = string.Empty;
        private string valueI3 = string.Empty;
        private string valueI4 = string.Empty;
        private string valueI5 = string.Empty;

        private string valueN1 = string.Empty;
        private string valueN2 = string.Empty;
        private string valueN3 = string.Empty;
        private string valueN4 = string.Empty;
        private string valueN5 = string.Empty;

        private string valueG1 = string.Empty;
        private string valueG2 = string.Empty;
        private string valueG3 = string.Empty;
        private string valueG4 = string.Empty;
        private string valueG5 = string.Empty;

        private string valueO1 = string.Empty;
        private string valueO2 = string.Empty;
        private string valueO3 = string.Empty;
        private string valueO4 = string.Empty;
        private string valueO5 = string.Empty;

        private int amountB1 = 1;
        private int amountB2 = 1;
        private int amountB3 = 1;
        private int amountB4 = 1;
        private int amountB5 = 1;

        private int amountI1 = 1;
        private int amountI2 = 1;
        private int amountI3 = 1;
        private int amountI4 = 1;
        private int amountI5 = 1;

        private int amountN1 = 1;
        private int amountN2 = 1;
        private int amountN3 = 1;
        private int amountN4 = 1;
        private int amountN5 = 1;

        private int amountG1 = 1;
        private int amountG2 = 1;
        private int amountG3 = 1;
        private int amountG4 = 1;
        private int amountG5 = 1;

        private int amountO1 = 1;
        private int amountO2 = 1;
        private int amountO3 = 1;
        private int amountO4 = 1;
        private int amountO5 = 1;

        protected override void OnInitialized()
        {
            if (ParamHelper.CheckData(Data, out var values, out var amounts))
            {
                valueB1 = values[0];
                valueI1 = values[1];
                valueN1 = values[2];
                valueG1 = values[3];
                valueO1 = values[4];

                valueB2 = values[5];
                valueI2 = values[6];
                valueN2 = values[7];
                valueG2 = values[8];
                valueO2 = values[9];

                valueB3 = values[10];
                valueI3 = values[11];
                valueN3 = values[12];
                valueG3 = values[13];
                valueO3 = values[14];

                valueB4 = values[15];
                valueI4 = values[16];
                valueN4 = values[17];
                valueG4 = values[18];
                valueO4 = values[19];

                valueB5 = values[20];
                valueI5 = values[21];
                valueN5 = values[22];
                valueG5 = values[23];
                valueO5 = values[24];

                amountB1 = amounts[0];
                amountI1 = amounts[1];
                amountN1 = amounts[2];
                amountG1 = amounts[3];
                amountO1 = amounts[4];

                amountB2 = amounts[5];
                amountI2 = amounts[6];
                amountN2 = amounts[7];
                amountG2 = amounts[8];
                amountO2 = amounts[9];

                amountB3 = amounts[10];
                amountI3 = amounts[11];
                amountN3 = amounts[12];
                amountG3 = amounts[13];
                amountO3 = amounts[14];

                amountB4 = amounts[15];
                amountI4 = amounts[16];
                amountN4 = amounts[17];
                amountG4 = amounts[18];
                amountO4 = amounts[19];

                amountB5 = amounts[20];
                amountI5 = amounts[21];
                amountN5 = amounts[22];
                amountG5 = amounts[23];
                amountO5 = amounts[24];
            }
        }

        private void GenerateLink()
        {
            if (NavManager != null)
            {
                string link = string.Empty;

                link += $"{ParamHelper.Encode(valueB1)}:{ParamHelper.Encode(amountB1.ToString())};";
                link += $"{ParamHelper.Encode(valueI1)}:{ParamHelper.Encode(amountI1.ToString())};";
                link += $"{ParamHelper.Encode(valueN1)}:{ParamHelper.Encode(amountN1.ToString())};";
                link += $"{ParamHelper.Encode(valueG1)}:{ParamHelper.Encode(amountG1.ToString())};";
                link += $"{ParamHelper.Encode(valueO1)}:{ParamHelper.Encode(amountO1.ToString())};";

                link += $"{ParamHelper.Encode(valueB2)}:{ParamHelper.Encode(amountB2.ToString())};";
                link += $"{ParamHelper.Encode(valueI2)}:{ParamHelper.Encode(amountI2.ToString())};";
                link += $"{ParamHelper.Encode(valueN2)}:{ParamHelper.Encode(amountN2.ToString())};";
                link += $"{ParamHelper.Encode(valueG2)}:{ParamHelper.Encode(amountG2.ToString())};";
                link += $"{ParamHelper.Encode(valueO2)}:{ParamHelper.Encode(amountO2.ToString())};";

                link += $"{ParamHelper.Encode(valueB3)}:{ParamHelper.Encode(amountB3.ToString())};";
                link += $"{ParamHelper.Encode(valueI3)}:{ParamHelper.Encode(amountI3.ToString())};";
                link += $"{ParamHelper.Encode(valueN3)}:{ParamHelper.Encode(amountN3.ToString())};";
                link += $"{ParamHelper.Encode(valueG3)}:{ParamHelper.Encode(amountG3.ToString())};";
                link += $"{ParamHelper.Encode(valueO3)}:{ParamHelper.Encode(amountO3.ToString())};";

                link += $"{ParamHelper.Encode(valueB4)}:{ParamHelper.Encode(amountB4.ToString())};";
                link += $"{ParamHelper.Encode(valueI4)}:{ParamHelper.Encode(amountI4.ToString())};";
                link += $"{ParamHelper.Encode(valueN4)}:{ParamHelper.Encode(amountN4.ToString())};";
                link += $"{ParamHelper.Encode(valueG4)}:{ParamHelper.Encode(amountG4.ToString())};";
                link += $"{ParamHelper.Encode(valueO4)}:{ParamHelper.Encode(amountO4.ToString())};";

                link += $"{ParamHelper.Encode(valueB5)}:{ParamHelper.Encode(amountB5.ToString())};";
                link += $"{ParamHelper.Encode(valueI5)}:{ParamHelper.Encode(amountI5.ToString())};";
                link += $"{ParamHelper.Encode(valueN5)}:{ParamHelper.Encode(amountN5.ToString())};";
                link += $"{ParamHelper.Encode(valueG5)}:{ParamHelper.Encode(amountG5.ToString())};";
                link += $"{ParamHelper.Encode(valueO5)}:{ParamHelper.Encode(amountO5.ToString())}";

                link = $"{NavManager.BaseUri}bingo/{ParamHelper.Encode(link)}";

                NavManager.NavigateTo(link);
            }
        }
    }
}
