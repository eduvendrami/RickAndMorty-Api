using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using RickAndMorty.Controllers;
using RickAndMorty.Service.RickAndMorty.Models;
using RickAndMorty.Service.RickAndMorty.Provider;

namespace RickAndMorty.Service.RickAndMorty.Service
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private readonly IRickAndMortyProvider _rickAndMortyProvider;

        public RickAndMortyService(
            IRickAndMortyProvider rickAndMortyProvider)
        {
            _rickAndMortyProvider = rickAndMortyProvider;
        }
        public async Task<ActionResult<CharactersResponse.Root>> GetCharactersAsync(
            CharactersRequest request)
        {
           return await ConsumeAsync(
               request.Name,
               "character");
        }

        private async Task<CharactersResponse.Root> ConsumeAsync(
            string name,
            string url)
        {
            var result = await _rickAndMortyProvider.GetAsync<CharactersResponse.Root>(
                name,
                url);

            return result.Data;
        }
    }
}
