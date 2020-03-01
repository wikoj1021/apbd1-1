using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);

            var content = await response.Content.ReadAsStringAsync();
            Regex rx = new Regex(@"[a-zA-Z1-9.]+\@[a-zA-Z]+\.[a-zA-Z]+");

            MatchCollection matches = rx.Matches(content);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
