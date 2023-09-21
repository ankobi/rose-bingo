using Microsoft.AspNetCore.Components;
using RoseBingo.Client.Utils;

namespace RoseBingo.Client.Pages
{
    public partial class Bingo
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

        private int counterB1 = 0;
        private int counterB2 = 0;
        private int counterB3 = 0;
        private int counterB4 = 0;
        private int counterB5 = 0;

        private int counterI1 = 0;
        private int counterI2 = 0;
        private int counterI3 = 0;
        private int counterI4 = 0;
        private int counterI5 = 0;
 
        private int counterN1 = 0;
        private int counterN2 = 0;
        private int counterN3 = 0;
        private int counterN4 = 0;
        private int counterN5 = 0;

        private int counterG1 = 0;
        private int counterG2 = 0;
        private int counterG3 = 0;
        private int counterG4 = 0;
        private int counterG5 = 0;

        private int counterO1 = 0;
        private int counterO2 = 0;
        private int counterO3 = 0;
        private int counterO4 = 0;
        private int counterO5 = 0;

        private List<string> originalValues = new();
        private List<int> originalAmounts = new();

        private List<string> currentValues = new();
        private List<int> currentAmounts = new();

        private Random random = new Random();
        private bool isValid;

        protected override void OnInitialized()
        {
            isValid = ParamHelper.CheckData(Data, out originalValues, out originalAmounts);
            if (isValid )
            {
                SetValues(originalValues, originalAmounts);
            }
        }

        private void Reset()
        {
            // Reset to original values and amounts
            SetValues(originalValues, originalAmounts);
        }

        private void Edit()
        {
            if (NavManager != null)
            {
                var currentLink = NavManager.Uri;
                currentLink = currentLink.Replace("bingo", "edit");
                NavManager.NavigateTo(currentLink);
            }
        }

        private void Shuffle(bool skipCenter)
        {
            var valuesCopy = currentValues.ToList();
            var amountsCopy = currentAmounts.ToList();
            var counters = new List<int>
            {
                counterB1,counterI1,counterN1,counterG1,counterO1,
                counterB2,counterI2,counterN2,counterG2,counterO2,
                counterB3,counterI3,counterN3,counterG3,counterO3,
                counterB4,counterI4,counterN4,counterG4,counterO4,
                counterB5,counterI5,counterN5,counterG5,counterO5
            };

            for (int i = 0; i < 100; i++)
            {
                int index1 = random.Next(0, valuesCopy.Count);
                int index2 = random.Next(0, valuesCopy.Count);

                if ((index1 == 12 || index2 == 12) && skipCenter)
                {
                    // Center shall not be touched!
                    continue;
                }

                // Swap fields
                string temp1 = valuesCopy[index1];
                valuesCopy[index1] = valuesCopy[index2];
                valuesCopy[index2] = temp1;

                int temp2 = amountsCopy[index1];
                amountsCopy[index1] = amountsCopy[index2];
                amountsCopy[index2] = temp2;

                int temp3 = counters[index1];
                counters[index1] = counters[index2];
                counters[index2] = temp3;
            }

            // Now set all new values
            SetValues(valuesCopy, amountsCopy, counters);
        }

        private void SetValues(List<string> newValues, List<int> newAmounts, List<int>? newCounters = null)
        {
            valueB1 = newValues[0];
            valueI1 = newValues[1];
            valueN1 = newValues[2];
            valueG1 = newValues[3];
            valueO1 = newValues[4];

            valueB2 = newValues[5];
            valueI2 = newValues[6];
            valueN2 = newValues[7];
            valueG2 = newValues[8];
            valueO2 = newValues[9];

            valueB3 = newValues[10];
            valueI3 = newValues[11];
            valueN3 = newValues[12];
            valueG3 = newValues[13];
            valueO3 = newValues[14];

            valueB4 = newValues[15];
            valueI4 = newValues[16];
            valueN4 = newValues[17];
            valueG4 = newValues[18];
            valueO4 = newValues[19];

            valueB5 = newValues[20];
            valueI5 = newValues[21];
            valueN5 = newValues[22];
            valueG5 = newValues[23];
            valueO5 = newValues[24];

            amountB1 = newAmounts[0];
            amountI1 = newAmounts[1];
            amountN1 = newAmounts[2];
            amountG1 = newAmounts[3];
            amountO1 = newAmounts[4];

            amountB2 = newAmounts[5];
            amountI2 = newAmounts[6];
            amountN2 = newAmounts[7];
            amountG2 = newAmounts[8];
            amountO2 = newAmounts[9];

            amountB3 = newAmounts[10];
            amountI3 = newAmounts[11];
            amountN3 = newAmounts[12];
            amountG3 = newAmounts[13];
            amountO3 = newAmounts[14];

            amountB4 = newAmounts[15];
            amountI4 = newAmounts[16];
            amountN4 = newAmounts[17];
            amountG4 = newAmounts[18];
            amountO4 = newAmounts[19];

            amountB5 = newAmounts[20];
            amountI5 = newAmounts[21];
            amountN5 = newAmounts[22];
            amountG5 = newAmounts[23];
            amountO5 = newAmounts[24];

            counterB1 = newCounters != null ? newCounters[0] : 0;
            counterI1 = newCounters != null ? newCounters[1] : 0;
            counterN1 = newCounters != null ? newCounters[2] : 0;
            counterG1 = newCounters != null ? newCounters[3] : 0;
            counterO1 = newCounters != null ? newCounters[4] : 0;

            counterB2 = newCounters != null ? newCounters[5] : 0;
            counterI2 = newCounters != null ? newCounters[6] : 0;
            counterN2 = newCounters != null ? newCounters[7] : 0;
            counterG2 = newCounters != null ? newCounters[8] : 0;
            counterO2 = newCounters != null ? newCounters[9] : 0;

            counterB3 = newCounters != null ? newCounters[10] : 0;
            counterI3 = newCounters != null ? newCounters[11] : 0;
            counterN3 = newCounters != null ? newCounters[12] : 0;
            counterG3 = newCounters != null ? newCounters[13] : 0;
            counterO3 = newCounters != null ? newCounters[14] : 0;

            counterB4 = newCounters != null ? newCounters[15] : 0;
            counterI4 = newCounters != null ? newCounters[16] : 0;
            counterN4 = newCounters != null ? newCounters[17] : 0;
            counterG4 = newCounters != null ? newCounters[18] : 0;
            counterO4 = newCounters != null ? newCounters[19] : 0;

            counterB5 = newCounters != null ? newCounters[20] : 0;
            counterI5 = newCounters != null ? newCounters[21] : 0;
            counterN5 = newCounters != null ? newCounters[22] : 0;
            counterG5 = newCounters != null ? newCounters[23] : 0;
            counterO5 = newCounters != null ? newCounters[24] : 0;

            currentValues = newValues;
            currentAmounts = newAmounts;
        }
    }
}
