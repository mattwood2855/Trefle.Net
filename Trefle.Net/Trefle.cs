using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Trefle.Net.Dto;

namespace Trefle.Net
{
    public class Trefle
    {
        const string TrefleApiBase = "https://trefle.io/api/v1";

        #region Fields
        HttpClient _httpClient;
        string _token;
        #endregion

        #region Properties
        public string PlantsEndpoint => TrefleApiBase + "/plants";
        public string PlantsSearchEndpoint => TrefleApiBase + "/plants/search";
        #endregion

        public Trefle(string token)
        {
            _token = token;

            _httpClient = new HttpClient();
        }

        public async Task<PlantResponseDto> GetPlant(string genusHyphenSpecies)
        {
            var uri = $"{PlantsEndpoint}/{genusHyphenSpecies}?token={_token}";

            try
            {
                var result = await _httpClient.GetAsync(uri);
                result.EnsureSuccessStatusCode();
                var response = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PlantResponseDto>(response, new JsonSerializerSettings
                {
                    Error = HandleDeserializationError
                });
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }

        public async Task<SearchResponseDto> Search(string query)
        {
            var uri = $"{PlantsSearchEndpoint}?q={query}&token={_token}";

            try
            {
                var result = await _httpClient.GetAsync(uri);
                result.EnsureSuccessStatusCode();
                var response = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SearchResponseDto>(response);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
