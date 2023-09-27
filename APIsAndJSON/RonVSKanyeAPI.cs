using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
       
       public static void RonQuote()
        {
            HttpClient client = new HttpClient();

            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronArray = JArray.Parse(ronResponse);
           
            Console.WriteLine($"Ron: {ronArray[0]}");
        }
        public static void KanyeQuote()
        {
            HttpClient client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

             var kanyeObj = JObject.Parse(kanyeResponse).GetValue("quote");
            Console.WriteLine($"Kanye: {kanyeObj}");
        }
        
    }
}
