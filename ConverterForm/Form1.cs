using System.Configuration;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConverterForm
{
    public partial class ConverterForm : Form
    {
        string ?apiKey = ConfigurationManager.AppSettings["ExchangeRateApiKey"];

        List<string> currencyCodes = new List<string>();

        private async Task<List<string>> GetCoins()
        {
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    var root = doc.RootElement;
                    var codes = root.GetProperty("supported_codes");

                    List<string> coins = new List<string>();

                    foreach (var item in codes.EnumerateArray())
                    {
                        string ?code = item[0].GetString();
                        coins.Add($"{code}");
                        currencyCodes.Add($"{code}");
                    }

                    return coins;
                }
            }
        }

        private bool IsValidCurrency (string currencyCode)
        {
            return currencyCodes.Contains(currencyCode);
        }

        private async Task<decimal> ConvertCurrency(string fromCurrency, string toCurrency, string amount)
        {        
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{fromCurrency}/{toCurrency}/{amount}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    var root = doc.RootElement;
                    var result = root.GetProperty("conversion_result").GetDecimal();

                    return result;
                }
            }
        }

        public ConverterForm()
        {
            InitializeComponent();
        }

        private async void ConverterForm_Load(object sender, EventArgs e)
        {

            try
            {
                var coins = await GetCoins();
                currencyOptions.DataSource = new List<string>(coins);
                convertCurrency.DataSource = new List<string>(coins);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar moedas: " + ex.Message);
            }

        }

        private async void convertCurrencyButton_Click(object sender, EventArgs e)
        {
            string fromCurrency, toCurrency;
            try
            {
                fromCurrency = currencyOptions.SelectedItem.ToString();
                toCurrency = convertCurrency.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a valid currency!");
                return;
            }

            if (!IsValidCurrency(toCurrency) || !IsValidCurrency(fromCurrency))
            {
                MessageBox.Show("Please select a valid currency!");
                return;
            }

            string inputCurrency = userCurrency.Text.Replace(",", ".");

            if (decimal.TryParse(inputCurrency, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal amount))
            {
                string formattedAmount = amount.ToString(System.Globalization.CultureInfo.InvariantCulture);

                decimal convertedValue = await ConvertCurrency(fromCurrency, toCurrency, formattedAmount);
                convertNumberLabel.Text = convertedValue.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please insert a valid ammount!");
            }

        }
    }

    /*Images from mamewmy and juicy_fish on freepik*/
}
