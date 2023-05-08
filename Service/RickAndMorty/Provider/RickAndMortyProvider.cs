using RestSharp;
using RickAndMorty.Service.Essential.Service;

namespace RickAndMorty.Service.RickAndMorty.Provider
{
    public class RickAndMortyProvider : IRickAndMortyProvider
    {
        public async Task<BaseResult<T>> GetAsync<T>(
            string character,
            string url)
        {
            var baseUrl = await GetBaseUrlAsync();
            var query = baseUrl + url;

            var result = new BaseResult<T>();

            try
            {
                var client = new RestClient(query);
                RestRequest request = new RestRequest(query, Method.Get);

                if (character != string.Empty)
                {
                    request.AddParameter("name", character);
                }

                var response = client.Execute(request);

                result.IsSuccess = true;
                result.Data = response.Content.DeserializeJson<T>();

            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = $"Erro ao consultar {query})";
            }

            return await Task.FromResult(result);
        }

        private async Task<string> GetBaseUrlAsync()
        {
            return "https://rickandmortyapi.com/api/";
        }
    }
}
