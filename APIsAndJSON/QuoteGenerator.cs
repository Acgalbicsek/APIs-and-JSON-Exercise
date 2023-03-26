using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeUrl = "https://api.kanye.rest";

            var kanyeRepsonse = client.GetStringAsync(kanyeUrl).Result;

            var kanyeQuote = JObject.Parse(kanyeRepsonse).GetValue("quote").ToString();

            Console.WriteLine($"--------");

            Console.WriteLine($"Ye: '{kanyeQuote}'");

            Console.WriteLine($"----------");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();  
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronUrl).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"----------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"-----------");

        }
    }
}
