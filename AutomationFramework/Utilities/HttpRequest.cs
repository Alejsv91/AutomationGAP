using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    public class HttpRequest
    {
        //    static async Task Main(string[] args)
        //    {
        //        var userName = "shopmanager";
        //        var passwd = "axY2 rimc SzO9 cobf AZBw NLnX";
        //        var url = "http://34.205.174.166//wp-json/wc/v3/products";

        //        using var client = new HttpClient();

        //        var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
        //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
        //                Convert.ToBase64String(authToken));

        //        var result = await client.GetAsync(url);

        //        var content = await result.Content.ReadAsStringAsync();
        //        Console.WriteLine(content);
        //    }

        //    async static void GetRequest(string url)
        //    {

        //        using (HttpClient client = new HttpClient())
        //        {
        //            using (HttpResponseMessage response = await client.GetAsync("https://www.google.com/"))
        //            {
        //                var test = response.Content();
        //            }
        //        }
        //    }
    }
}
