using RestSharp;
using RickAndMorty.Service.Essential.Service;
using RickAndMorty.Service.RickAndMorty.Models;

namespace RickAndMorty.Service.RickAndMorty.Provider
{
    public interface IRickAndMortyProvider
    {
        public Task<BaseResult<T>> GetAsync<T>(
            string character,
            string url);
    }
}
