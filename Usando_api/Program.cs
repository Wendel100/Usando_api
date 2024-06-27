using Newtonsoft.Json;
using QuickType;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        var response = await client.GetAsync("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL");
        var content = await response.Content.ReadAsStringAsync();
        var json = JsonConvert.DeserializeObject(content);


            Console.WriteLine(json);
        
    }
}


