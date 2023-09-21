using System.Text;

namespace RoseBingo.Client.Utils
{
    public static class ParamHelper
    {
        public static string Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        public static bool Decode(string text, out string decodedString)
        {
            decodedString = string.Empty;

            try
            {
                decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(text));
                return true;
            }
            catch
            {
                // Catch all errors, in that case we will just return false
            }

            return false;
        }

        public static bool CheckData(string data, out List<string> values, out List<int> amounts)
        {
            values = new();
            amounts = new();
            if (!string.IsNullOrWhiteSpace(data) && Decode(data, out var decodedData))
            {
                var parameters = decodedData.Split(';');

                // Should be 5*5 parameters for Bingo
                if (parameters.Length == 25)
                {
                    foreach (var parameter in parameters)
                    {
                        // Each parameter has two properties, text and amount
                        var parts = parameter.Split(':');
                        if (parts.Length == 2)
                        {
                            // Again each part is encoded in base64
                            if (Decode(parts[0], out var value) && Decode(parts[1], out var amountText) && int.TryParse(amountText, out var amount))
                            {
                                values.Add(value);
                                amounts.Add(amount);
                            }
                            else
                            {
                                // Directly stop processing, one entry could not be decoded
                                break;
                            }
                        }
                    }

                    if (values.Count == 25 && values.Count == 25)
                    {
                        // Everything fine, we can go on
                        //SetValues(originalValues, originalAmounts);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
