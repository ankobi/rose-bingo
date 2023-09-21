using Microsoft.AspNetCore.Components;
using System.Text;

namespace RoseBingo.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private NavigationManager? NavManager { get; set; }

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

        private string _link = string.Empty;

        private void GenerateLink()
        { 
            _link = string.Empty;

            _link += $"{Enc(valueB1)}:{Enc(amountB1.ToString())};";
            _link += $"{Enc(valueI1)}:{Enc(amountI1.ToString())};";
            _link += $"{Enc(valueN1)}:{Enc(amountN1.ToString())};";
            _link += $"{Enc(valueG1)}:{Enc(amountG1.ToString())};";
            _link += $"{Enc(valueO1)}:{Enc(amountO1.ToString())};";

            _link += $"{Enc(valueB2)}:{Enc(amountB2.ToString())};";
            _link += $"{Enc(valueI2)}:{Enc(amountI2.ToString())};";
            _link += $"{Enc(valueN2)}:{Enc(amountN2.ToString())};";
            _link += $"{Enc(valueG2)}:{Enc(amountG2.ToString())};";
            _link += $"{Enc(valueO2)}:{Enc(amountO2.ToString())};";

            _link += $"{Enc(valueB3)}:{Enc(amountB3.ToString())};";
            _link += $"{Enc(valueI3)}:{Enc(amountI3.ToString())};";
            _link += $"{Enc(valueN3)}:{Enc(amountN3.ToString())};";
            _link += $"{Enc(valueG3)}:{Enc(amountG3.ToString())};";
            _link += $"{Enc(valueO3)}:{Enc(amountO3.ToString())};";

            _link += $"{Enc(valueB4)}:{Enc(amountB4.ToString())};";
            _link += $"{Enc(valueI4)}:{Enc(amountI4.ToString())};";
            _link += $"{Enc(valueN4)}:{Enc(amountN4.ToString())};";
            _link += $"{Enc(valueG4)}:{Enc(amountG4.ToString())};";
            _link += $"{Enc(valueO4)}:{Enc(amountO4.ToString())};";

            _link += $"{Enc(valueB5)}:{Enc(amountB5.ToString())};";
            _link += $"{Enc(valueI5)}:{Enc(amountI5.ToString())};";
            _link += $"{Enc(valueN5)}:{Enc(amountN5.ToString())};";
            _link += $"{Enc(valueG5)}:{Enc(amountG5.ToString())};";
            _link += $"{Enc(valueO5)}:{Enc(amountO5.ToString())}";

            _link = $"{NavManager.BaseUri}bingo/{Enc(_link)}";
        }

        private string Enc(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }
}
