using System.Net.Http;
using System.Threading.Tasks;
using ElQuecus.Models.WebModels;
using Newtonsoft.Json;

namespace ElQuecus
{
    internal static class EchoNestService
    {
        private static readonly HttpClient _client = new HttpClient();
        private const string ApiKey = "?api_key=QZEFLQ3CDCDOYYGRV";
        private const string BaseURL = "http://developer.echonest.com/api/v4/artist/";

        private static async Task<EchoNestArtistBio> GetArtsitBio(string name)
        {
            var responce =
                await _client.GetAsync(BaseURL + $"biographies{ApiKey}&name={name}&format=json&result=1");
            return JsonConvert.DeserializeObject<EchoNestArtistBio>(responce.Content.ReadAsStringAsync().Result);
        }

        private static async Task<EchoNestArtistTerms> GetArtistTerms(string name)
        {
            var responce = await _client.GetAsync(BaseURL + $"terms{ApiKey}&name={name}&format=jsom");
            return JsonConvert.DeserializeObject<EchoNestArtistTerms>(responce.Content.ReadAsStringAsync().Result);
        }


    }
}