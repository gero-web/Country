using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Country.Models.SerializerModel;



namespace Country.Data
{
    public class API
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public API()
        {

        }

       

        public async static Task<SerializerCountry> GetData(string countryName )
        {
            var response = await httpClient.GetAsync($"https://restcountries.eu/rest/v2/name/{countryName}");
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var content = await response.Content.ReadAsStringAsync();

            content = content.Substring(1, content.Length - 2);
            var result = JsonConvert.DeserializeObject<SerializerCountry>(content);
            return result;
        }
    }
}
