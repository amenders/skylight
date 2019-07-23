using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Skylight
{
    public class AsteroidService
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string key = "AVv9ZHXdiw6thco0noQF101oOnAmWUJPl2gUXGPy";

        public AsteroidService()
        {
            Console.WriteLine("I AM AN ASTEROID");
        }

        public async Task<object> GetAsteroidByIdAsync(int id)
        {
            var data = await httpClient.GetStringAsync($"https://api.nasa.gov/neo/rest/v1/neo/{id}?api_key={key}");
            return JsonConvert.DeserializeObject(data);
        }
    }
}
