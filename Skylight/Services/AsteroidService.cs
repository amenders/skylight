using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Skylight
{
    public class AsteroidService
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string baseUrl = "https://api.nasa.gov/neo/rest/v1";
        private readonly string key = "DEMO_KEY";

        public async Task<object> GetAsteroidByIdAsync(int id)
        {
            var data = await httpClient.GetStringAsync($"{baseUrl}/neo/{id}?api_key={key}");
            return JsonConvert.DeserializeObject(data);
        }

        public async Task<object> GetAsteroidByDateAsync(DateTime start, DateTime end)
        {
            if (DateTime.Compare(start.AddDays(7), end) < 0
                || DateTime.Compare(start, end) > 0)
            {
                throw new InvalidAsteroidParametersException($"Invalid dates for call to GetAsteroidByDateAsync: start: {start}, end: {end}");
            }

            var startString = start.ToString("yyyy-MM-dd");
            var endString = end.ToString("yyyy-MM-dd");

            var data = await httpClient.GetStringAsync($"{baseUrl}/feed?start_date={startString}&end_date={endString}&api_key={key}");
            return JsonConvert.DeserializeObject(data);
        }
    }
}
