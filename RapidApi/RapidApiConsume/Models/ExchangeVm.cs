namespace RapidApiConsume.Models;

public class ExchangeVm
{//Edit-Paste Special-Paste JSON As Classes


    public string base_currency_date { get; set; }
    public Exchange_Rates[] exchange_rates { get; set; }
    public string base_currency { get; set; }


    public class Exchange_Rates
    {
        public string currency { get; set; }
        public string exchange_rate_buy { get; set; }
    }

}
